// Задача 23

// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

if(x > 1)
CubTable(x);
else 
{
    Console.WriteLine("Введено некорректное значение");
}
void CubTable(int x)
{
    int count = 1;

    while (count <= x)
    {
        Console.WriteLine($"|{count, 5} | {Math.Pow(count, 3), 5}|");
        count++;
    }

}