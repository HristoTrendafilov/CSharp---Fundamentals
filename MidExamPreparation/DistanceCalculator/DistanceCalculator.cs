using System;
using System.Linq;
using System.Collections.Generic;
namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double stepsMade = double.Parse(Console.ReadLine());
            double stepLenght = double.Parse(Console.ReadLine());
            double totalDistance = double.Parse(Console.ReadLine());

            double totalSteps = 0;
            int shorterSteps = 0;

            for (int i = 1; i <= stepsMade; i++)
            {
                if (i % 5==0)
                {
                    totalSteps += stepLenght - (stepLenght * 0.30);
                    shorterSteps++;
                }
                else
                {
                    totalSteps += stepLenght;
                }
            }
            double totalStepsInMeters = totalSteps / 100;
            double percentage = (totalStepsInMeters / totalDistance) * 100;

            if (totalStepsInMeters < totalDistance)
            {
                Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
            }
            else
            {
                Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
            }
        }
        
    }
}
