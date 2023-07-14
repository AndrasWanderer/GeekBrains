/* Задайте двумерный массив размера m на n, каждый элемент 
 в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
 */
 
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
int[,] GetIntArray(int countRow, int countColum)
{
    int[,] array = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
//---------------------------
int countRow = Prompt("Введите количество строк ");
int countColum = Prompt("Введите количество столбцов ");
int[,] array = GetIntArray(countRow, countColum);
PrintIntArray(array);