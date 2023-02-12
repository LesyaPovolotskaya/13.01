// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите натурельное число ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNamber(number);


void NaturalNamber(int num)
{
    if (num == 0) return;
    NaturalNamber(num - 1); //Если метод вызыватся на последней строке, то будет хвостовая рекурсия.

    Console.Write($"{num}");
}