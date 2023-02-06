﻿// Задача 38:
//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 2);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}


double MaxElementArray(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"MAX => {maxElement}");
    return maxElement;
}


double MinElementArray(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    // Console.WriteLine();
    Console.Write($"MIN => {minElement}");
    return minElement;
}



double [] array = CreateArrayRndDouble(7, 2, 11);
PrintArrayDouble(array);
// double DifferenceMaxMinElem = MaxElementArray(array) - MinElementArray(array);
double DifferenceMaxMinElem = Math.Round(MaxElementArray(array) - MinElementArray(array), 2);
Console.WriteLine();
Console.WriteLine($"Разница между MAX и MIN элементами массива -> {DifferenceMaxMinElem}");