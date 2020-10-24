using System;
using System.Linq;
using System.Collections.Generic;
namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Include")
                {
                    string additionalShop = command[1];
                    shops.Add(additionalShop);
                }
                else if (command[0] == "Visit")
                {
                    int numberOfShops = int.Parse(command[2]);

                    if (numberOfShops > shops.Count)
                    {
                        //possible problem
                        continue;
                    }
                    if (command[1] == "first")
                    {
                        for (int j = 0; j < numberOfShops; j++)
                        {
                            shops.RemoveAt(0);
                        }
                    }
                    else if (command[1] == "last")
                    {
                        for (int j = 0; j < numberOfShops; j++)
                        {
                            shops.RemoveAt(shops.Count-1);
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int firstShopIndex = int.Parse(command[1]);
                    int secondsShopIndex = int.Parse(command[2]);

                    if(shops.ElementAtOrDefault(firstShopIndex)!=null && shops.ElementAtOrDefault(secondsShopIndex) != null)
                    {
                        string firstShop = shops[firstShopIndex];
                        string secondShop = shops[secondsShopIndex];

                        shops.RemoveAt(firstShopIndex);
                        shops.Insert(firstShopIndex, secondShop);

                        shops.RemoveAt(secondsShopIndex);
                        shops.Insert(secondsShopIndex, firstShop);
                        
                    }
                }
                else if (command[0] == "Place")
                {
                    string shop = command[1];
                    int shopIndex = int.Parse(command[2]);

                    if (shopIndex <= shops.Count - 1)
                    {
                        shops.Insert(shopIndex + 1, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ",shops));
        }
    }
}
