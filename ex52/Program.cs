int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

double[] newarray = FindColumnsElementsAverage(array);

PrintArray(newarray);


int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];

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

double[] FindColumnsElementsAverage(int[,] array)
{

    double[] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newarray[j] = Math.Round((sum / array.GetLength(0)),1);
    }  
    return newarray;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}