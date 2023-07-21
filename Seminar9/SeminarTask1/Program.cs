/* Рекурсия
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int RecursSum(int number)
{
    int sum = 0;
    if ((number/10) == 0) return number;
    sum = RecursSum(number/10) + number%10;

    return sum;
}

int number = Request("число ");
Console.WriteLine(RecursSum(number));