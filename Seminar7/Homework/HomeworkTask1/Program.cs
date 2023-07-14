/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
*/

Console.WriteLine("Введите кол-во строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

double[,] array = new double[countRow, countColumn];

for(int i = 0; i < countRow; i++)
{
    for(int j = 0; j < countColumn; j++)
    {
        array[i,j] = new Random().NextDouble() * (10 - 1) + 1;
    }
}

for(int i = 0; i < countRow; i++)
{
    for(int j = 0; j < countColumn; j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}