using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= counter; i++)
            {
                char a = char.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
