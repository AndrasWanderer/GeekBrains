/*
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/


int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Pow(int A, int B)
{
    if(B == 1) return A;
    int C = Pow(A,B-1)*A;
    return C;
}

int numberA = Request("Number A: ");
int numberB = Request("Number B: ");

Pow(numberA,numberB);
Console.WriteLine(Pow(numberA,numberB));