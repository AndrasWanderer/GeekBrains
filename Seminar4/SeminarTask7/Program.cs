int[] a = { 1365, 2357, 3475, 2645, 6675, 2536, 1, 75, 234, 78678, 12345, };
Console.WriteLine("Введите искомое число из массива");
int b = int.Parse(Console.ReadLine());
bool trueOrFalse = false;
int temp = a[0];
for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < a.Length; j++)
    if (a[i] < a[j])
    {
        temp = a[i];
        a[i]=a[j];
        a[j] = temp;
    }
}
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " ");
}