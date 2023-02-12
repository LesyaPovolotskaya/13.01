// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }

//  Console.WriteLine(FactorialRec(10)); // 3628800

Console.WriteLine("Введите число А ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int num2 = Convert.ToInt32(Console.ReadLine());
int power = PowerNumbers(num1, num2);

Console.WriteLine($"{num1} в степени {num2} равно  {power}");


int PowerNumbers(int number1, int number2)
{
    if (number2 == 0) return 1;
    return number1 * PowerNumbers(number1, number2 - 1);
}