// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = CreateArray(8);
PrintArrayNum(arr);
PrintArray(arr);


int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}




void PrintArrayNum(int[] array)
{
    int count = array.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(array[i]);
        i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
}


void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    Console.Write(" -> ");
    Console.Write("[");
    while (i < count)
    {
        Console.Write(array[i]);
        i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}















