// // Задача 52. Задайте двумерный массив из целых чисел.
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageNum(int[,] array)
{
    double[] columnsArray = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        double sumColumns = Math.Round(sum / array.GetLength(0), 2);

        columnsArray[j] = sumColumns;
    }
    return columnsArray;

}

void PrintArray(double[] arr)
{
    Console.Write("  ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",   ");
        else Console.Write(arr[i]);
    }
    Console.Write("   ");
}



int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine("");
double[] averageNum = AverageNum(matrix);
PrintArray(averageNum);



