using System;

namespace LastDigitName
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numLastDiget = number % 10;
            if (numLastDiget == 1)
            {
                Console.WriteLine("one");
            }
            else if (numLastDiget == 2)
            {
                Console.WriteLine("two");
            }
            else if (numLastDiget == 3)
            {
                Console.WriteLine("three");
            }
            else if (numLastDiget == 4)
            {
                Console.WriteLine("four");
            }
            else if (numLastDiget == 5)
            {
                Console.WriteLine("five");
            }
            else if (numLastDiget == 6)
            {
                Console.WriteLine("six");
            }
            else if (numLastDiget == 7)
            {
                Console.WriteLine("seven");
            }
            else if (numLastDiget == 8)
            {
                Console.WriteLine("eight");
            }
            else if (numLastDiget == 9)
            {
                Console.WriteLine("nine");
            }
            else if (numLastDiget == 0)
            {
                Console.WriteLine("zero");
            }


        }
    }
}
