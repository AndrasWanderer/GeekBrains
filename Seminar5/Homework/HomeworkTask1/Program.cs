//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] array = new int[10];
int CountEven = 0;
for (int i=0; i < array.Length; i++) 
{
    array[i] = new Random().Next(100, 1000);
    if ( array[i] >= 100 && array[i] <= 1000 && array[i] % 2 == 0)
    {
    CountEven += 1;
    }
    Console.Write(array[i] + ";");
}

Console.WriteLine(" -> " + CountEven);