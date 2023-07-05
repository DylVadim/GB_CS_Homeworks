﻿int[] array = GenerateArray(100,999,10);              
                                                   
PrintArray(array);                                

int count = GetNumberOfEvenNumbers(array);

Console.Write($" -> {count}.");




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
    Console.WriteLine("Количество чётных чисел в массиве:");
    Console.Write(@"[{0}]", string.Join(",", array)); 
}                                         


int GetNumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++ ;
        }
    }
    return count;
}