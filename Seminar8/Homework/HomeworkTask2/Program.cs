/*
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

static int[,] GenerateRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

    return array;
}
static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static int FindSmallestSumRow(int[,] array)
    {
        int smallestSum = int.MaxValue;
        int smallestSumRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            if (sum < smallestSum)
            {
                smallestSum = sum;
                smallestSumRowIndex = i;
            }
        }

        return smallestSumRowIndex;
    }
//----------------------------------------------
int[,] array = GenerateRandomArray(5, 5);
PrintArray(array);
int smallestSumRowIndex = FindSmallestSumRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {smallestSumRowIndex + 1}");