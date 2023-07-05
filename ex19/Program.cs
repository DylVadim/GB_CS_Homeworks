Console.WriteLine("Чтобы узнать является ли число палиндромом,");
Console.Write("Введите пятизаначное число ");
int num = int.Parse(Console.ReadLine()??"");
NumberCheck(num);

///////////////////////////////////////////////////////
void NumberCheck(int num)
{
    int num1 = num / 10000;
    int num2 = num % 10000 / 1000;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if(num >= 10000 && num < 100000)
    {
        if(num1 == num5 && num2 == num4)
        Console.WriteLine($"{num} -> да");
        else Console.WriteLine($"{num} -> нет");
    }
    else Console.WriteLine($"Введенное число {num} не является пятизначным");
}