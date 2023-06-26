//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
Console.Write("Please, enter integer number: ");
int Num = int.Parse(Console.ReadLine());

int mod7 = Num%7;
int mod23 = Num%23;

if (mod7 == 0 && mod23 == 0)
{
    Console.WriteLine("yes"); 
}else{
  Console.WriteLine("no");  
}