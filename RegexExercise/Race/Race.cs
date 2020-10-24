using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ");
            var racers = new Dictionary<string, double>();

            while (true)
            {
                var command = Console.ReadLine();

                if(command=="end of race")
                {
                    break;
                }

                var name = new String(command.Where(Char.IsLetter).ToArray());
                int distance = 0;

                if (names.Contains(name))
                {
                    if (racers.Keys.Contains(name))
                    {
                        foreach (var character in command)
                        {
                            if (char.IsDigit(character))
                            {
                                distance += ((int)character) - '0';
                            }
                        }
                        racers[name] += distance;
                        continue;
                    }

                    foreach (var character in command)
                    {
                        if (char.IsDigit(character))
                        {
                            distance += ((int)character) - '0';
                        }
                    }
                    racers.Add(name, distance);
                }
            }

            int counter = 0;
            foreach (var racer in racers.OrderByDescending(x=>x.Value))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }
            }       
        }
    }
}
