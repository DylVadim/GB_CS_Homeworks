/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22
*/

Console.Clear();
Console.Write("Введите Первое число: ");
string UserInputNumber_a = Console.ReadLine() ?? "";
int a = int.Parse(UserInputNumber_a);
Console.Write("Введите Второе число: ");
string UserInputNumber_b = Console.ReadLine() ?? "";
int b = int.Parse(UserInputNumber_b);
Console.Write("Введите Третье число: ");
string UserInputNumber_c = Console.ReadLine() ?? "";
int c = int.Parse(UserInputNumber_c);
int MaxNum = c;

if(a > MaxNum)
{
    MaxNum = a;
}
else
{
    if(b > MaxNum)
    {
        MaxNum = b;
    }
}

Console.WriteLine ($"Из чисел {a}, {b}, {c} Максимально число -> {MaxNum}");