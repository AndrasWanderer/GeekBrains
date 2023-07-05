 //Задача 25: Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

double result = Math.Pow(A,B);

Console.WriteLine($"{A} в натуральной степени {B} равна: {result}");