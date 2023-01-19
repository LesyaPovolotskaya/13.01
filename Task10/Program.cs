// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

int res = SecondDigit(threeDigitNumber);

Console.WriteLine($"результат -> {res}");

int SecondDigit(int threeDigNum)
{
    int num1 = threeDigitNumber % 100;
    int num2 = threeDigitNumber % 10;
    int num3 = (num1 - num2) / 10;
    res = num3;
    return res;
}





