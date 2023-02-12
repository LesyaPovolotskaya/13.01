// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое натуральное число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int num2 = Convert.ToInt32(Console.ReadLine());

int funcAkkerman = AkkermanFunction(num1, num2);
Console.WriteLine($"m = {num1}, n = {num2} -> A({num1}, {num2}) = {funcAkkerman}");

int AkkermanFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number1 > 0 && number2 == 0) return AkkermanFunction(number1 - 1, 1);
    else return AkkermanFunction(number1 - 1, AkkermanFunction(number1, number2 - 1));
}
