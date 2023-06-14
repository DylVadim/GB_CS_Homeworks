/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Программа показывает все чётные числа от 1 до ");
Console.Write("Введите целое число: ");
string UserInputNumber = Console.ReadLine() ?? "";
int Num = int.Parse(UserInputNumber);
int Count = 1;

while (Count <= Num)
{
    if(Count % 2 == 0)
    {
        Console.WriteLine($"{Num} -> {Count}");
        Count++;
    }
    else
    {
        Count++;
    }
}