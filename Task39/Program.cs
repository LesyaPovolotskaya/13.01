
// // Задача 39: Напишите программу, которая перевернёт
// // одномерный массив (последний элемент будет на первом
// // месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]


// int[] CreateAtteyRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++) // либо arr.Length вместо i < size;
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArrey(int[] arr)
// {
//     Console.Write("[");

//     for (int i = 0; i < arr.Length; i++) // либо arr.Length вместо i < size;
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]},");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");
// }

// //  0 1 2 3 4
// // [1 2 3 4 5] -> [5 4 3 2 1]

// void ReverseArrey(int[ arrey])
// {
// for (int i = 0; i < arrey.Length/2; i++)//в 2 раза меньше итераций. т.к. меняем сразу и первое и последнее число
// {
//     int temp = array[i]; //1
//     array[i] = array[arrey.Length - 1] - i;
//     array[arrey.Length - 1] - i = temp;
// }
// }

// int [] arr = CreateArreyRndInt (5,1,9);
// PrintArray(arr);
// ReverseArray(arr);
// Console.WriteLine();
// PrintArray(arr);

// Array.Reverse(arr);
// Console.WriteLine();
// PrintArray

ДОДЕЛАТЬ!