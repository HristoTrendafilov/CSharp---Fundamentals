using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());

            double poundsToDollars = britishPounds * 1.31;
            Console.WriteLine($"{poundsToDollars:f3}");
        }
    }
}
