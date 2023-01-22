// Задача 19
// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool palindrome = Palindrome(number);

Console.WriteLine(palindrome ? "ДА" : "НЕТ");
bool Palindrome(int num)
{
    int firstDigit = num / 10000;
    int fiveDigit = num % 10;
    int temp = firstDigit - fiveDigit;
    int secondDigit = temp / 100;
    int fourDigit = temp % 10;
    bool result;
    if (firstDigit == fiveDigit || secondDigit == fourDigit)
        result = true;
    else
        result = false;
    return result;
}





// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// number = number < 0 ? -number : number;
// if (number < 9999 || number > 99999)
// {
//     Console.WriteLine("Число не является пятизначным.");
//     return;
// }
// if (Palindrome(number) == true) Console.WriteLine($"Число {number} является палиндромом.");
// else
//     Console.WriteLine($"Число {number} не является палиндромом.");
// bool Palindrome(int num)
// {
//     int firstDigit;
//     int secondDigit;
//     int fourDigit;
//     int fiveDigit;
//     bool result;
//     firstDigit = num / 10000;
//     secondDigit = num / 1000 % 10;
//     fourDigit = num / 10 % 10;
//     fiveDigit = num % 10;
//     if (firstDigit == fiveDigit && secondDigit == fourDigit)
//         result = true;
//     else
//         result = false;
//     return result;
// }






















