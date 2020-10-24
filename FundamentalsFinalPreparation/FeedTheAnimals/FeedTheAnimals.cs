using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalsAndFood = new Dictionary<string, int>();
            var areasAndCount = new Dictionary<string, int>();

            while (true)
            {
                var command = Console.ReadLine().Split(":");


                if (command[0] == "Last Info")
                {
                    break;
                }
                var animal = command[1];
                var foodLimit = int.Parse(command[2]);
                var area = command[3];

                if (command[0] == "Add")
                {
                    if (animalsAndFood.ContainsKey(animal))
                    {
                        animalsAndFood[animal]+=foodLimit;
                        continue;
                    }
                    if (areasAndCount.ContainsKey(area))
                    {
                        areasAndCount[area]++;
                        animalsAndFood.Add(animal, foodLimit);
                        continue;
                    }
                        animalsAndFood.Add(animal, foodLimit);
                        areasAndCount.Add(area, 1);
                }
                else if (command[0] == "Feed")
                {
                    if (animalsAndFood.ContainsKey(animal))
                    {
                        animalsAndFood[animal] -= foodLimit;

                        if (animalsAndFood[animal] <= 0)
                        {
                            Console.WriteLine($"{animal} was successfully fed");
                            areasAndCount[area]--;
                            if (areasAndCount[area] == 0)
                            {
                                areasAndCount.Remove(area);
                            }
                            animalsAndFood.Remove(animal);
                        }
                    }
                }
            }
            Console.WriteLine("Animals:");

            foreach (var animal in animalsAndFood.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }
            if (areasAndCount.Count>0)
            {
                Console.WriteLine("Areas with hungry animals:");
                foreach (var area in areasAndCount.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{area.Key} : {area.Value}");
                }
            }
        }
    }
}
