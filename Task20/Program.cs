// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координаты точки A: ");
Console.Write("Ax: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Ay: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("Bx: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("By: ");
double by = Convert.ToDouble(Console.ReadLine());

double dist = Distans(ax, ay, bx, by);

Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distans(double x1, double y1, double x2, double y2)
{
     return  Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}



