﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());
Week(day);

static void Week(int day)
{
    if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }

    else
    {
        Console.WriteLine("Это выходной день");
    }
}

if(day>7)
{
    Console.WriteLine("Некорректное число!");
}