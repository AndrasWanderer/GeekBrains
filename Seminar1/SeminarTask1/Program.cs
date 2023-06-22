//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.


Console.Write("Enter the numberA:");

int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter the numberB:");

int numberB = int.Parse(Console.ReadLine());

if(numberB*numberB == numberA)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}
