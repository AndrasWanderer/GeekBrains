// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125
//3 -> 1, 8, 27 
//5 -> 1, 8, 27, 64, 125

void PrintSqrTab(int N)
{
    if (N < 1) 
    {
        Console.WriteLine("There are no valid numbers");
        }
        else
        {
            Console.Write($"{N} --> ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"{Math.Pow(i,3)}; ");
                }
                    Console.WriteLine(" ");
                }
            }
//----------------------------------------
Console.Write("Please n: ");
int num = int.Parse(Console.ReadLine());
PrintSqrTab(num);
