//Задача 6: 
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int number;

Console.Write("Введите число: ");

number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}