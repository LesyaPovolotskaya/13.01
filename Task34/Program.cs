﻿// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}

int ElementsCount(int[] massive, int min, int max)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 ==0)
        result++;
    }
    return result;
}

int[] arr = CreateArrayRndInt(5, 100, 999);
PrintArray(arr);
int answer = ElementsCount(arr, 100, 999);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве' -> {answer}");