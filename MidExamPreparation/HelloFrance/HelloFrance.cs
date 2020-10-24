using System;
using System.Linq;
using System.Collections.Generic;
namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('-','>', '|').Where(x => !string.IsNullOrEmpty(x)).ToList();
            List<string> itemName = new List<string>();
            List<double> itemPrice = new List<double>();
            List<double> newPrice = new List<double>();
            double profit = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    itemName.Add(items[i]);
                }
                else
                {
                    itemPrice.Add(double.Parse(items[i]));
                }

            }
            double budget = double.Parse(Console.ReadLine());

            for (int i = 0; i < itemName.Count; i++)
            {
                if (itemName[i] == "Clothes" && budget >= itemPrice[i] && itemPrice[i]<=50)
                {
                    budget -= itemPrice[i];
                    profit += itemPrice[i] * 0.4;
                    newPrice.Add(itemPrice[i] += itemPrice[i] * 0.4);

                }
                if (itemName[i] == "Shoes" && budget >= itemPrice[i] && itemPrice[i] <= 35)
                {
                    budget -= itemPrice[i];
                    profit += itemPrice[i] * 0.4;
                    newPrice.Add(itemPrice[i] += itemPrice[i] * 0.4);
                }
                if (itemName[i] == "Accessories" && budget >= itemPrice[i] && itemPrice[i] <= 20.50)
                {
                    budget -= itemPrice[i];
                    profit += itemPrice[i] * 0.4;
                    newPrice.Add(itemPrice[i] += itemPrice[i] * 0.4);
                }
            }
            for (int i = 0; i < newPrice.Count; i++)
            {
                Console.Write($"{newPrice[i]:f2} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:f2}");
            if (budget + newPrice.Sum() >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
