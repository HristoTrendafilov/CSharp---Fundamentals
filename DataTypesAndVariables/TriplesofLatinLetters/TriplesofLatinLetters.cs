using System;

namespace TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    for (int k = 0; k <counter; k++)
                    {
                        Console.WriteLine($"{(char)(i='a')}{(char)(j='a')}{(char)(k+'a')}");
                    }
                }
            }


                    
             
            
        }
    }
}
