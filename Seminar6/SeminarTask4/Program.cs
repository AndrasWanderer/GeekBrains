// Есть массив цел, могут повторяться числа,

int[] a = { 1, 2, 3, 3, 3, 2, 2, 1, 4, 5, 6, 7, 8, 9, 2, 1 };
for (int i = 0; i < a.Length; i++)
{
    int count = -1;
    int temp = a[i];
    for (int j = 0; j < a.Length; j++)
    {

        if (temp == a[j] && temp != 0)
        {
            count++;
            a[j] = 0;
        }
    }
    if (count > 0)
        Console.WriteLine($"Число {temp} встречается {count} раз");
}