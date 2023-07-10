// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
array[0] = 0;
array[1] = 1;
Console.Write(array[0] + " " + array[1] + " ");
for (int i = 2; i < N; i++)
{
    array[i] = array[i - 1] + array[i - 2];
    Console.Write(array[i] + " ");
}