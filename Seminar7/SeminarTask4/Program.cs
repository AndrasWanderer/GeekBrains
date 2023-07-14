// Cоздайте двумерный массив случайных чисел.
// вывести среднее арифметическое каждого столбца

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] GetRandomIntArray(int countRow, int countColum)
{
    int[,] array = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = new Random().Next(2, 9);
        }
    }
    return array;
}
double[] GetMeanColumn(int[,] array)
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
//---------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetRandomIntArray(countRow, countColum);
PrintIntArray(array);

Console.WriteLine();
string str = string.Join(", ", GetMeanColumn(array));
Console.WriteLine(str);