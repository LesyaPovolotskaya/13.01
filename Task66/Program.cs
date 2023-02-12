
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите число M ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sumElements = SumNaturalElements(num1, num2);
Console.WriteLine($"Сумма чисел равна {sumElements}");


int SumNaturalElements(int number1, int number2)
{
    if (number1 < number2) return number1 + SumNaturalElements(number1 + 1, number2);
    if (number1 > number2) return number1 + SumNaturalElements(number1, number2 + 1);
    if (number1 == number2) return number1;
    else return 0;
}
