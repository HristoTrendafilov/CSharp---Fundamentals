using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int kilometer = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {kilometer} square km.");
        }
    }
}
