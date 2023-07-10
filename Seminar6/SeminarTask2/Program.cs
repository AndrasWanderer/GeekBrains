// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число ");
int dec = int.Parse(Console.ReadLine());
string binary = string.Empty;

while(dec != 0)
{
    int mod = dec%2;
    binary = mod.ToString() + binary;
    dec = dec/2;
}


Console.WriteLine(binary);