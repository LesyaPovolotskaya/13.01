﻿// Задача 31: 
// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
//-20.


int[] CreateAtteyRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) // либо arr.Length вместо i < size;
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArrey(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++) // либо arr.Length вместо i < size;
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


//Возвращаем массив и суммами

int[] GetSumNegativePositiveElem(int[] arr)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[] { sumNegative, sumPositive };
}


int GetNegativeElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
}

int GetPositiveElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
}






// int[] array = CreateAtteyRndInt(12, -9, 9); //Заполнили массив 12 элементами от -9 до 9
// PrintArrey(array);
// int[] sumNegativePositiveElem = GetSumNegativePositiveElem(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных элементов = {sumNegativePositiveElem[0]}");
// Console.WriteLine($"Сумма положительных элементов = {sumNegativePositiveElem[1]}");



int sumNegativeElem = GetNegativeElem(array);
int sumPositiveElem = GetPositiveElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");

