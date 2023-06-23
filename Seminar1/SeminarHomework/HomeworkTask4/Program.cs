// Задача 8: 
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N;

Console.Write("Введите число: ");

N = int.Parse(Console.ReadLine());

 Console.Write($"Чётные числа от 1 до {N}: ");

 for(int i = 2; i <= N; i += 2) 
    {
      Console.Write(i + " ");
    }