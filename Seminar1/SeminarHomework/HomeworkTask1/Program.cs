//Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите первое число: ");

int a,b;

a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

b = int.Parse(Console.ReadLine());

if(a>b)
{
   Console.WriteLine($"{a} больше, чем {b}");
} else if (a<b)
    {
         Console.WriteLine($"{b} больше, чем {a}");
}
else
{
    Console.WriteLine("Числа равны");
}
