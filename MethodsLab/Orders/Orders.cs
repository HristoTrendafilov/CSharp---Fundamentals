using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingPrice();
        }
        static void PrintingPrice()
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            
            if (product == "coffee")
            {
                double price = 1.50 * quantity;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "water")
            {
                double price = 1.00 * quantity;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "coke")
            {
                double price = 1.40 * quantity;
                Console.WriteLine($"{price:f2}");
            }
            else if (product == "snacks")
            {
                double price = 2.00 * quantity;
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine("Invalid Product!");
            }


        }
    }
}
