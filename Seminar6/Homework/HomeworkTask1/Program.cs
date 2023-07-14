//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

static int GetCount(int m)
{
    int count = 0;
    for (int i = 1; i <= m; i++)
    {
        Console.Write($"Введите {i}-ое число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

//-----------------------------------------------
Console.Write("Введите количество M: ");
int m = int.Parse(Console.ReadLine());
int count = GetCount(m);
Console.WriteLine($"Количество чисел, больших 0: {count}");