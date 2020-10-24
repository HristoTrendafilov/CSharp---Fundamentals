using System;
using System.Linq;
using System.Collections.Generic;
namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> totalBox = new List<Box>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "end")
                {
                    break;
                }

                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                double quantity = double.Parse(input[2]);
                double price = double.Parse(input[3]);

                double totalPrice = price * quantity;

                Item item = new Item();
                {
                    item.Name = itemName;
                    item.Price = totalPrice;
                    
                }

                Box box = new Box();
                {
                    box.SerialNumber = serialNumber;
                    box.Item = itemName;
                    box.ItemQuantity = quantity;
                    box.PriceForABox = price;
                    box.Price = totalPrice;
                    totalBox.Add(box);
                }
            }
            List<Box> filteredBoxes = totalBox.OrderByDescending(x => x.Price).ToList();

            foreach (Box box in filteredBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
    class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public double ItemQuantity { get; set; }
        public double PriceForABox { get; set; }

        public double Price { get; set; }
    }
}
