// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите координату b1 ? ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k1  ? ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2 ? ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2 ? ");
double k2 = Convert.ToDouble(Console.ReadLine());

double PointOfIntersectionOfLinesX(double x1, double y1, double x2, double y2)
{
    double variableX = -(x1 -x2) / (y1 - y2);
    return variableX;
}
double PointOfIntersectionOfLinesY(double y1, double x, double x1)
{
    double variableY = y1 * PointOfIntersectionOfLinesX(b1, k1, b2, k2) + x1;
    return variableY;
}

double varX = PointOfIntersectionOfLinesX(b1, k1, b2, k2);
double varY = PointOfIntersectionOfLinesY(k1, PointOfIntersectionOfLinesX(b1, k1, b2, k2), b1);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} => ({varX}, {varY})");

if (k1 == k2)
{
    Console.WriteLine();
    Console.Write("прямые параллельны друг другу ");
}
if (b1 == b2)
{
    
    Console.WriteLine();
    Console.Write("прямые совпадают");
}
