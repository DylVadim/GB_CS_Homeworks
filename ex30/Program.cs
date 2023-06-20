Console.Clear(); 
int[] randomArray = new int[8]; 



for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = Rand ();

    Console.Write($"{randomArray[i]} "); 
}

int Rand()
{
    return new Random().Next(0,2); 
}
