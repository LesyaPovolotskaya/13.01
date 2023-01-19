// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет




// // ВАРИАНТ 1

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a == 1)
// {
//     Console.WriteLine("НЕТ");
// }
// else if (a == 2)
// {
//     Console.WriteLine("НЕТ");
// }
// else if (a == 3)
// {
//     Console.WriteLine("НЕТ");
// }
// else if (a == 4)
// {
//     Console.WriteLine("НЕТ");
// }
// else if (a == 5)
// {
//     Console.WriteLine("НЕТ");
// }
// else if (a == 6)
// {
//     Console.WriteLine("ДА");
// }
// else if (a == 7)
// {
//     Console.WriteLine("ДА");
// }
// else Console.WriteLine("Введите число от 1 до 7");



//ВАРИАНТ 2
Console.WriteLine("Введите число от 1 до 7: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool isWday = IsWday(number1);
Console.WriteLine(isWday ? "НЕТ" : "ДА");

bool IsWday(int num1)
{
    return num1 == 1 || num1 == 2 || num1 == 3 || num1 == 4 || num1 == 5;
}



