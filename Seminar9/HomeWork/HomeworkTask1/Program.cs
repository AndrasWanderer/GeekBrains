/* Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
Ваша задача вывести на экран максимальное количество следующих друг за другом 1.

Пример 1:
Исходный массив: [1, 1, 0, 1, 1, 1]
*/


int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2);
}

Console.WriteLine("Исходный массив: " + string.Join(", ", array));

int maxCount = 0;
int currentCount = 0;

foreach (int element in array)
{
    if (element == 1)
    {
        currentCount++;
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }
    }
    else
    {
        currentCount = 0;
    }
}

Console.WriteLine("Максимальное количество последовательных единиц: " + maxCount);