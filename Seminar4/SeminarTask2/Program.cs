// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Введите ваше число");
int a = int.Parse(Console.ReadLine());
string sa = a.ToString();
int j=0;
for (int i=0; i < sa.Length; i++) 
{
    j++;
}
Console.WriteLine($"Количество цифр в числе равно {j}");
