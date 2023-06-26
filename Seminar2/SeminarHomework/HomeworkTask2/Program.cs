//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int thirdDigit = (number % 10) % 10;

Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");

if(number < 100)
{
    Console.WriteLine("Ошибка!Число не трехзначное.");
}