// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int amound = Amound(number);

Console.WriteLine($"Количество цифр  = {amound} ");                   

int Amound(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}