//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int randInt = new Random().Next(100,1000);
Console.WriteLine(randInt);
int digit2 = randInt/100;

int digit0 = randInt%10;

int result = digit2*10 + digit0;
Console.WriteLine(result);