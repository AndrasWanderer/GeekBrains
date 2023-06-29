// Напишите программу, которая принимает на вход 
//координаты точки(X и Y),
// причем X и Y не равно 0 и выдает номер четверти
//плоскости в которой находится эта точка

int GetAreaNumber(int x, int y)
{
    int numberArea = 0;

    if(x>0 && y>0)
    {
        numberArea = 1;
    }


    if(x<0 && y>0)
    {
        numberArea = 2;
    }
    
    if(x<0 && y<0)
    {
        numberArea = 3;
    }
    
    if(x>0 && y<0)
    {
        numberArea = 4;
    }
    return numberArea;
}

//-------------------------

Console.WriteLine("Введите координаты x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты y: ");
int x = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не должны быть равны 0");
}
else
{
    int result = GetAreaNumber(x,y);
    Console.WriteLine($"Номер четвертой вашей точки: {result}");
}

