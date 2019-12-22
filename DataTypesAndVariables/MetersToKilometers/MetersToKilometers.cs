
using System;

namespace MetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double metersToKilometers = (meters / 1000);
            Console.WriteLine($"{metersToKilometers:f2}");

        }
    }
}
