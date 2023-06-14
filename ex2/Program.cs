/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();
Console.Write("Введите Первое число: ");
string UserInputNumber_a = Console.ReadLine() ?? "";
int a = int.Parse(UserInputNumber_a);
Console.Write("Введите Второе число: ");
string UserInputNumber_b = Console.ReadLine() ?? "";
int b = int.Parse(UserInputNumber_b);
int MaxNum = b;
if(a > b)
{
    MaxNum = a;
}


Console.WriteLine($"Из чисел {a} и {b} Максимально число -> {MaxNum}");