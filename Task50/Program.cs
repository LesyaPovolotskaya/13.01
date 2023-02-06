// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет




Console.WriteLine("Введите строку ");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int columnsNum = Convert.ToInt32(Console.ReadLine());

int [,] newarray = CreateMatrixRndInt(4, 5, -9, 9);
PrintMatrix(newarray);


bool searchElementMatrix = SearchElementMatrix(newarray, rowsNum, columnsNum);
if (searchElementMatrix)
{
	Console.WriteLine($"Числа с индексами {rowsNum} и {columnsNum} нет в массиве");
}
else
{
	Console.WriteLine($"Число с индексами {rowsNum} и {columnsNum} -> {newarray[rowsNum, columnsNum]}");
}




int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
	int[,] matrix = new int[rows, columns];
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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
			else Console.Write($"{matrix[i, j], 4} ");
		}	
		Console.WriteLine("|");
    }
}

bool SearchElementMatrix (int [,] array, int rows, int column)
{

	if (rows >= 0 & rows <= array.GetLength(0) & column >= 0 & column <= array.GetLength(1))
	{
		return false;
	}
	else
	{
		return true;
	}
}





