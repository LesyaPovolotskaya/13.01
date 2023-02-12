// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите натурельное M ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натурельное N ");
int num2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(num1, num2);


void NaturalNumbers(int number1, int number2)
{
    if (number1 >= number2)
    {
        Console.Write($"{number1} ");
        NaturalNumbers(number1 - 1, number2);
    }
}