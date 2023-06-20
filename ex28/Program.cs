Console.Clear();
int number = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int prodNumbers = GetProdNumbers(number);
Console.WriteLine($"{number} -> {prodNumbers}");



int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetProdNumbers(int number)
{
    int prod = 1;
    while(number > 0)
    {
        prod *= number;
        number--;
    }
    return prod;
}