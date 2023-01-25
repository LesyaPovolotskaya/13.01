﻿// Задача 27: 
// Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел  {sumNumbers} ");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}


//программа работает при вводе заданных чисел и прочих числе, если они начинаются 
//с единицы, выходи сумма на 1 меньше. (Только при вводе 11 показывается верная сумма)
//При вводе числа 123 давет некорректное значение (сумма = 5). При 
// введении числа 321 сумма правильная 6.