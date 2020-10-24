using System;

namespace PrintingTriangle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int column = 1; column <= counter; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
            for (int column = counter-1; column>=1; column--)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}
