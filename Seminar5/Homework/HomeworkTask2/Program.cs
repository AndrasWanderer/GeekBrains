// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

static int GetSumOdd(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (array[i] >= 1 && array[i] <= 100 && array[i] % 2 != 0)
        {
            Sum += array[i];
        }
        Console.Write(array[i] + ";");
    }
    return Sum;
}
//-------------------------------------------------
int[] array = new int[10];
int SumOdd = GetSumOdd(array);
Console.WriteLine(" -> " + SumOdd);