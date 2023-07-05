int[] array = GenerateArray(-10,10,10);              
                                                   
PrintArray(array);                                

int sum = SumElementsOddIndexes(array);

Console.WriteLine($" -> {sum}.");

///////////////////////////////////////////////////////////////////


int[] GenerateArray(int min, int max, int length)   
{                                                   
    Random random = new Random();                   
    int[] array = new int [length];                  
                                                    
    for (var i = 0; i < array.Length; i++)          
    {
        array[i] = random.Next(min, max + 1);       
    }
    return array;                                  
} 


void PrintArray(int[] array)                       
{
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массивах:");
    Console.Write(@"[{0}]", string.Join(",", array)); 
}                                         


int SumElementsOddIndexes(int[] array)
{
    int sum = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = array[i] + sum ;
        }
    }
    return sum;
}