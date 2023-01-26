// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int power = Power(numberA, numberB);
if (numberB > 0)
{
    Console.WriteLine($" {numberA} в {numberB}-й степени = {power} ");
}
else
    Console.WriteLine("Число B должно быть натуральным : ");




int Power(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
        // int result = Math.Pow(numberA, numberB);
    }
    return result;



}
