using System;
using System.Linq;
using System.Collections.Generic;
namespace ChristmanSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalCost = 0;
            int spirit = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    totalCost += 2 * quantity;
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    totalCost += 5 * quantity;
                    totalCost += 3 * quantity;
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    totalCost += 15 * quantity;
                    spirit += 17;
                    if (i % 3 == 0)
                    {
                        spirit += 30;
                    }
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    totalCost += 5 + 3 + 15;
                }
                if(days%10==0 && i==days)
                {
                    spirit -= 30;
                }

            }
            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
