/*
 Задайте двумерный массив из целых чисел. 
 Найдите среднее арифметическое элементов в каждом столбце.
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

double[] GetAverage(int[,] array)
{
    double[] ResultArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn = sumColumn + array[j, i];
        }
        ResultArray[i] = sumColumn / array.GetLength(0);
    }
    return ResultArray;
}

//--------------------------------

int[,] array = GenerateRandomArray(4 , 4);
PrintArray(array);
string str = string.Join(", ", GetAverage(array));
Console.WriteLine(str);