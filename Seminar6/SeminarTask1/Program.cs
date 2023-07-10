// Напишите программу, 
//которая принимает на вход три числа и проверяет, 
//может ли существовать 
//треугольник с сторонами такой длины.

Console.WriteLine("1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("3: ");
int c = int.Parse(Console.ReadLine());

if (a < (b+c) && b < (a+c) && c<(b+a))
{
    Console.WriteLine("Треугольник");
}

else  Console.WriteLine("Не Треугольник");