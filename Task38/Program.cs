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
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


double MinMaxNumbersArrayDouble(int[] arr)
{
    double minNumber = arr[0];
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber)
        {
            maxNumber = arr[i];
        }
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
        }
        
        
    }
     double result = maxNumber - minNumber;
    return result;
}

double[] arr = CreateArrayRndDouble(5, 5, 10);
PrintArrayDouble(arr);
double result = MinMaxNumbersArrayDouble(arr);
Console.WriteLine(result);

