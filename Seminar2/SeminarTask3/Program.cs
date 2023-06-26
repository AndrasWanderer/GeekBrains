//Напишите программу которая выводит случайное число из отрезка [10,99] 
//и показывает наибольшую цифру числа

int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число{randomNumber}");

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшее число: {firstDigit}");
}

else (secondDigit > firstDigit);
{
    Console.WriteLine($"Наибольшее число: {secondDigit}");
}

