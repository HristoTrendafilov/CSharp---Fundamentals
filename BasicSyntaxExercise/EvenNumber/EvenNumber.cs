using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                while (num % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");

                    num = int.Parse(Console.ReadLine());
                }
            }
            if (num % 2 == 0)
            {
                if (num > 0)
                {
                    Console.WriteLine($"The number is: {num}");
                }
                else if (num == 0)
                {
                    Console.WriteLine($"The number is: {num}");
                }
                else if (num < 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                }
            }
           
        }
    }
}
