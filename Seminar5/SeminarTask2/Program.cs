//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
int L;
int[] N = new int[5];
int[] result;
if(((N.Length / 2) % 10) > 0)
{
    L =  (N.Length /2) + 1;
}
else
{
    L = N.Length / 2;
}

result = new int[L];

for (int i=0; i < N.Length; i++) 
{
    N[i] = new Random().Next(0,10); 
    Console.Write(N[i] + " ");
}

Console.Write(" -> ");

for(int i = 0; i < N.Length / 2; i++)
{
   int element = N[i] * N[N.Length-1-i];
   result[i] = element;
   Console.Write(result[i] + " ");
}
Console.WriteLine();