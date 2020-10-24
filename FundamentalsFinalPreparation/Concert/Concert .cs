using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandAndNames = new Dictionary<string, List<string>>();
            var bandAndTime = new Dictionary<string, int>();
            var time = 0;

            while (true)
            {
                var command = Console.ReadLine().Split("; ");

                if(command[0]== "start of concert")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    var band = command[1];
                    var names = command[2].Split(", ");

                    if (bandAndNames.ContainsKey(band))
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (!bandAndNames[band].Contains(names[i]))
                            {
                                bandAndNames[band].Add(names[i]);
                            }
                        }
                    }
                    else
                    {
                        bandAndNames.Add(band, new List<string>());

                        for (int i = 0; i < names.Length; i++)
                        {
                            if (!bandAndNames[band].Contains(names[i]))
                            {
                                 bandAndNames[band].Add(names[i]);
                            }

                        }
                    }
                }
                else if (command[0] == "Play")
                {
                    var band = command[1];
                    var timeBand = int.Parse(command[2]);

                    if (bandAndTime.ContainsKey(band))
                    {
                        bandAndTime[band] += timeBand;
                    }
                    else
                    {
                        bandAndTime.Add(band, timeBand);
                    }
                    time += timeBand;
                }
            }
            Console.WriteLine($"Total time: {time}");

            foreach (var band in bandAndTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            var bandName = Console.ReadLine();

            if (bandAndNames.ContainsKey(bandName))
            {
                Console.WriteLine(bandName);
                foreach (var name in bandAndNames[bandName])
                {
                    Console.WriteLine($"=> {name}");
                }
            }
        }
    }
}
