using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace PracticeSessions
{
    class Program
    {
        static void Main(string[] args)
        {
            var roadAndRacers = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine().Split("->");

                if (command[0] == "END")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    var road = command[1];
                    var racer = command[2];

                    if (!roadAndRacers.ContainsKey(road))
                    {
                        roadAndRacers.Add(road, new List<string>());
                        roadAndRacers[road].Add(racer);
                    }
                    else
                    {
                        roadAndRacers[road].Add(racer);
                    }
                }
                else if (command[0] == "Move")
                {
                    var currentRoad = command[1];
                    var racer = command[2];
                    var nextRoad = command[3];

                    if (roadAndRacers[currentRoad].Any(x => x.Contains(racer)))
                    {
                        roadAndRacers[currentRoad].Remove(racer);
                        roadAndRacers[nextRoad].Add(racer);
                    }
                }
                else if (command[0] == "Close")
                {
                    var road = command[1];
                    roadAndRacers.Remove(road);
                }
            }
            Console.WriteLine("Practice sessions:");
            foreach (var road in roadAndRacers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{road.Key}");

                foreach (var item in road.Value)
                {
                    Console.WriteLine($"++{item}");
                }
            }
        }
    }
}
