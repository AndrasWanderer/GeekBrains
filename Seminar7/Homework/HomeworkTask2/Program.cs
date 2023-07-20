/*
Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
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
static void ExamPos(int[,] array,int row ,int column)
{
if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
{
    int element = array[row, column];
    Console.WriteLine($"Значение элемента: {element}");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
}

}
//--------------------------------------------------------------
int[,] array = GenerateRandomArray(4, 4);

PrintArray(array);

Console.Write("Введите строку элемента: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите столбец элемента: ");
int column = int.Parse(Console.ReadLine());

ExamPos(array,row,column);