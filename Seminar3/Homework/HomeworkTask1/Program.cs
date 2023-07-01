// Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

bool IsPalindrome(int number)
{
    string numberString = number.ToString();
    int length = numberString.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (numberString[i] != numberString[length - i - 1])
            return false;
    }

    return true;
}

//---------------------------------------------------

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка! Введено число, не являющееся пятизначным.");
    return;
}

bool isPalindrome = IsPalindrome(number);
Console.WriteLine($"Является ли число {number} палиндромом: {isPalindrome}");
