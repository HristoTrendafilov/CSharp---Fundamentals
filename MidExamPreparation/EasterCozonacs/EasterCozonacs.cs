using System;
using System.Linq;
using System.Collections.Generic;
namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceForKgFloor = double.Parse(Console.ReadLine());

            double pricePackEggs = priceForKgFloor * 0.75;
            double percentForMilk = priceForKgFloor * 0.25;
            double totalPriceForMilk = priceForKgFloor + percentForMilk;
            double milkPrice250ml = totalPriceForMilk / 4;
            double totalPriceForCozonac = priceForKgFloor + pricePackEggs + milkPrice250ml;

            int eggsCollected = 0;
            int cozonacsMade = 0;
            int counter = 0;

            while(budget>=0)
            {
                if (budget <totalPriceForCozonac)
                {
                    break;
                }
                budget -= totalPriceForCozonac;
                cozonacsMade++;
                eggsCollected += 3;
                counter++;

                if (counter % 3 == 0)
                {
                    eggsCollected -= cozonacsMade - 2;
                }
            }
            Console.WriteLine($"You made {cozonacsMade} cozonacs! Now you have {eggsCollected} eggs and {budget:f2}BGN left.");

        }
    }
}
