/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

// Организация ввода данных
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

// Расчёт
int CountNumbers = GetCountNumbers(A);

// Вывод
Console.WriteLine($"{A} -> {CountNumbers}");

////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine() ?? "", out int userNumber))
            return userNumber;
        
        Console.WriteLine(errorMessage);
    }
}

int GetCountNumbers(int number)
{
    int count = 0;

    while(number > 0)
    {
        number = number/10;
        count++;
    }

    return count;
}