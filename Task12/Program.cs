// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// //int remainder = RemNum()
// if(number1 % number2 == 0)
// {
//     Console.WriteLine("КРАТНО");
// }
// else
// {
    
//     Console.WriteLine($"НЕ КРАТНО, остаток -> {(number1 % number2)}");
// }


Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder1 = RemNum(number1 % number2);




// if(number1 % number2 == 0)
// {
//     Console.WriteLine("КРАТНО");
// }
// else
// {
    
//     Console.WriteLine($"НЕ КРАТНО, остаток -> {(number1 % number2)}");
// }