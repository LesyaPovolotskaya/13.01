
// Задача 36: 
// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// НЕ РЕШЕНА

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



int SumArray(int[] massive, int min, int max)
{
    int sum = 0;
    for (int i = 1; i < massive.Length; i+=2)
    {
        sum += massive[i];
       
    }
    return sum;
}


int[] arr = CreateArrayRndInt(7, 0, 10);
PrintArray(arr);
int sum = SumArray(arr, 0, 10);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива -> {sum}");




