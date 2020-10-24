using System;
using System.Linq;
using System.Collections.Generic;
namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int santa = 0;
       
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if(command[0]== "Merry")
                {
                    break;
                }

                if (command[0] == "Jump")
                {
                    int lenght = int.Parse(command[1]);

                    if (santa + lenght >= houses.Length)
                    {
                        santa = (santa + lenght) % houses.Length;

                        if (houses[santa] == 0)
                        {
                            Console.WriteLine($"House {santa} will have a Merry Christmas.");
                            continue;
                        }
                    }
                    else
                    {
                        santa += lenght;
                    }
                    if (houses[santa] == 0)
                    {
                        Console.WriteLine($"House {santa} will have a Merry Christmas.");
                    }
                    else
                    {
                        houses[santa] -= 2;
                    }
                }
            }
            Console.WriteLine($"Santa's last position was {santa}.");

            int count = 0;
            for (int i = 0; i < houses.Length; i++) 
            {
                if (houses[i] == 0)
                {
                    count++;
                }
            }
            if (count == houses.Length)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {houses.Length-count} houses.");
            }
        }
    }
}
