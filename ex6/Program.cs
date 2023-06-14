/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Clear();
Console.Write("Введите целое число: ");
string UserInputNumber = Console.ReadLine() ?? "";
int Num = int.Parse(UserInputNumber);

if(Num % 2 == 0)
{
    Console.WriteLine($"Число {Num} является чётным");
}
else
{
    Console.WriteLine($"Число {Num} не является чётным");
}