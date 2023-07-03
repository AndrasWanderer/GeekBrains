// Поиск элемента в массиве
//1 - любой
//2 - бинарный поиск
// метод

int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Введите искомое число из массива");
int b = int.Parse(Console.ReadLine());
TrueOrFalse(a, b);

void TrueOrFalse(int[] a, int b)
{
bool trueOrFalse = false;
int j=0;
for (int i = 0; i < a.Length; i++)
{
    j++;
    if (b == a[i]) { trueOrFalse = true; break; }
}
if (trueOrFalse)
{
    Console.WriteLine($"Да, число входит в массив, его индекс равен {j}");
}
else
{
    Console.WriteLine("Нет, число не входит в массив");
}
}