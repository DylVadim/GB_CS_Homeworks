int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

Console.Write("Введите номер строки, начиная обратный отсчет c нуля: ");
int row = Convert.ToInt32(Console.ReadLine() ?? ""); ;

Console.Write("Введите номер столбца, начав обратный отсчет c нуля: ");
int column = Convert.ToInt32(Console.ReadLine() ?? ""); ;

bool result = GetElementsByIndexes(row, column, array);

Console.WriteLine(result);





int[,] CreateRandom2DArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

bool GetElementsByIndexes(int row, int column, int[,] array)
{
    if (row < array.GetLength(0) || column < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива c указанным индексом равен {array[row, column]}");
        return true;
    }
    else
    {
        Console.WriteLine("Указанный индекс не существует");
        return false;
    }
}