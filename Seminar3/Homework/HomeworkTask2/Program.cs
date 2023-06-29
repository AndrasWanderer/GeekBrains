// Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double GetLength(double point1_crd1, double point1_crd2,double point1_crd3,double point2_crd1,double point2_crd2,double point2_crd3)
{
    return Math. Sqrt((Math.Pow(point1_crd1 - point2_crd1,2) + Math.Pow(point1_crd2 - point2_crd2,2) + Math.Pow(point1_crd3 - point2_crd3,2)));
}
//----------------------------------------------
Console.Write("Please, enter x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Please, enter y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Please, enter z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Please, enter x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Please, enter y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Please, enter z2: ");
double z2 = double.Parse(Console.ReadLine());
Console.WriteLine($"length = {GetLength(x1,y1,z1,x2,y2,z2)}");