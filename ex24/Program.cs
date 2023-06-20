﻿// Организация ввода данных
int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

// Расчёт
int sumNumbers = GetSumNumbers(A);

// Формирование вывода
Console.WriteLine($"{A} -> {sumNumbers}");

//////////////////////
int GetSumNumbers(int number)
{
    int sum = 0;

    while(number > 0)
    {
        sum += number;
        number--;
    }

    return sum;
}

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