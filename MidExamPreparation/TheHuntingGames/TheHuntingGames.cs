using System;
using System.Linq;
using System.Collections.Generic;
namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            double neededWater = daysOfAdventure * playersCount * waterPerDay;
            double neededFood = daysOfAdventure * playersCount * foodPerDay;


            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;

                if (groupEnergy < 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    groupEnergy += (groupEnergy * 0.05);
                    neededWater -= (neededWater*0.30);
                }
                if (i % 3 == 0)
                {
                    neededFood -= neededFood / playersCount;
                    groupEnergy += groupEnergy*0.10;
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else 
            {
                Console.WriteLine($"You will run out of energy. You will be left with {neededFood:f2} food and {neededWater:f2} water.");
            }
        }
    }
}
