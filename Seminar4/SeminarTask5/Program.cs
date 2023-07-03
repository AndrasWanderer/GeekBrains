// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите ваше число N");
int N = int.Parse(Console.ReadLine());
int sum=1;
for (int i=1; i <= N; i++) 
{
    sum *= i;
}
Console.WriteLine($"Ваше искомое произведение равно {sum}");