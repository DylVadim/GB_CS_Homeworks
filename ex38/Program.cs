double[] array = GenerateDoubleArray(1,10,5);              
                                                   
PrintArray(array);                                

GetDifference(array);

/////////////////////////////////////////////////////////////


double [] GenerateDoubleArray(int min, int max, int length)   
{                                                   
    Random random = new Random();                   
    double[] array = new double [length];                  
                                                    
    for (var i = 0; i < array.Length; i++)          
    {
        array[i] = random.NextDouble();       
    }
    return array;                                  
} 


void PrintArray(double[] array)                       
{
     Console.WriteLine(@"[{0}]", string.Join("; ", array)); 
}                                         


void GetDifference(double [] array)   
{                                                   
    double min = array[0];
    double max = array[0];
    double diff = 0;
                                                  
    for (var i = 0; i < array.Length; i++)          
    {
       if (array[i] > max)
          {
            max = array[i];
          }
         
            if (array[i] < min)
           {
                min = array[i];
           }
    }
    diff = max - min ;
    Console.WriteLine($" => {max} - {min} = {diff}.");
}
