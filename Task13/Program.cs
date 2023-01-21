// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = -1;

// int thirdDigitnumber = ThirdDigitnumber(number);
// Console.WriteLine($"Третья цифра числа -> {result}");

// int ThirdDigitnumber(int number)
// {

//     if (number >= 100)
//     {
//         while (number > 999)
//         {
//             number = number / 10;
//         }
//         result = number % 10;

//     }
//     return result;

// }


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


while (number > 999)
{

    number = number / 10;

    number = number % 10;
    Console.WriteLine($"Третья ЦИФРА -> {number}");
}
if (number > 99 && number < 1000)
{
    number = number % 10;
    Console.WriteLine($"Третья цифра -> {number}");
}
    else
    {
        number = 1 - 99;
        Console.WriteLine("Третьей цифры нет");
    }

