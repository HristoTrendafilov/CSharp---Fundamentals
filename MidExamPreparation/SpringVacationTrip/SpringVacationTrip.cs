using System;
using System.Linq;
using System.Collections.Generic;
namespace SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double roomPrice = double.Parse(Console.ReadLine());

            double foodExpences = food * people * daysOfTrip;
            double hotelPrice = roomPrice * people * daysOfTrip;
            if (people > 10)
            {
                hotelPrice -= hotelPrice * 0.25;
            }
            double currentExpences = foodExpences + hotelPrice;

            for (int i=1;i<=daysOfTrip;i++)
            {
                if (currentExpences >= budget)
                {
                    break;
                }
                double travelledDistance = double.Parse(Console.ReadLine());
                currentExpences += travelledDistance * fuelPrice;

                if (i%3==0)
                {
                    currentExpences += currentExpences * 0.4;
                }
                if (i % 5 == 0)
                {
                    currentExpences += currentExpences * 0.4;
                }
                if (i % 7 == 0)
                {
                    currentExpences -= currentExpences / people;
                }
            }
            if (budget >= currentExpences)
            {
                double totalBudget = budget - currentExpences;
                Console.WriteLine($"You have reached the destination. You have {totalBudget:f2}$ budget left.");
            }
            else
            {
                double totalBudget = currentExpences - budget;
                Console.WriteLine($"Not enough money to continue the trip. You need {totalBudget:f2}$ more.");
            }
        }
    }
}
