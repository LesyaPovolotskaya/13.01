// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 - > {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10; //7
    int secondDigit = num % 10; //8
    int result = firstDigit > secondDigit ? firstDigit: secondDigit; // тернарный оператор
    return result;
}


// int firstDigit = number / 10; //7
// int secondDigit = number % 10; //8

// // if (firstDigit > secondDigit) 
// //     Console.WriteLine ($"Наибольшая цифра числа -> {firstDigit}");
// // else 
// //     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit: secondDigit; // тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {result}");




Влад 20:05
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"{num1} кратно {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} не кратно {num2} , остаток {num1 % num2}");
// }

 int remains = Remains( num1,num2);
Console.WriteLine($"кратно ");

int Remains(int number1,int number2 )
{
    return number1 % number2;