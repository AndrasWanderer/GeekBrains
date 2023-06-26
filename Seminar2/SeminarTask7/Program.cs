// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if((a*a==b)||(b*b==a))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}