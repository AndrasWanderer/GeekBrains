//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void PrintIntervals(int n)
{        
    switch(n)
    {            
        case 1:                
        Console.WriteLine("X > 0, y > 0");
        break;
        case 2:
        Console.WriteLine("X < 0, y > 0");
        break;
        case 3:
        Console.WriteLine("X < 0, y < 0"); 
        break;
        case 4:
        Console.WriteLine("X > 0, y < 0");
        break;
        default:
        Console.WriteLine("Error");
        break;
        }
    }

//---------------------------------

Console.Write("Please, enter integer number of quarter: ");

int Num = int.Parse(Console.ReadLine());
PrintIntervals(Num);