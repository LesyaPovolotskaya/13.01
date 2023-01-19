// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool mult = Mult(number1);
Console.WriteLine(mult ? "ДА" : "НЕТ");

bool Mult(int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;
}



// if(number1 % number2 == 0)
// {
//     Console.WriteLine("КРАТНО");
// }
// else
// {

//     Console.WriteLine($"НЕ КРАТНО, остаток -> {(number1 % number2)}");
// }


// Console.WriteLine("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int remainder1 = RemNum(number1 % number2);
