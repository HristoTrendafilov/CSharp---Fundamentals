using System;
using System.Linq;
using System.Collections.Generic;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Add")
                {
                    int passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int newPassengers = int.Parse(input);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= maxCapacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
