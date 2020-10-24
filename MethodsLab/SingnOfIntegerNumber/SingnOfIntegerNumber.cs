using System;

namespace SingnOfIntegerNumber
{
    class Program
    {
        static void valueOfInteger()
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            valueOfInteger();
        }
    }
}
