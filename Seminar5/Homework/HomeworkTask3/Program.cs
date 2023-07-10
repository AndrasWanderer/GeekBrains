//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[5];
double min = 100;
double max = 0;
for (int i= 0; i < array.Length; i++)
{
   array[i] = Math.Round(new Random().NextDouble() * 100, 2);
   if (array[i] > max)
   {
       max = array[i];
   }

   if (array[i] < min)
   {
      min = array[i];
   }
   Console.Write(array[i] + ";");
}
Console.WriteLine(" -> " + (max - min));