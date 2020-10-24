using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var regex = new Regex(@"@(?<planetName>[A-Z]+[a-z]+)[^@\-!:>]*(?:\w*)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[A]|[D])[^@\-!:>]*!->(?<soldiers>\d+)");
            var planets = new Dictionary<string, List<string>>();
            planets["A"] = new List<string>();
            planets["D"] = new List<string>();


            for (int i = 0; i < counter; i++)
            {
                string command = Console.ReadLine();
                var wordCounter = Regex.Matches(command, @"[s,t,a,r,S,T,A,R]").Count;
                var sb = new StringBuilder();

                for (int j = 0; j < command.Length; j++)
                {
                    sb.Append((char)(command[j] - wordCounter));
                }
                command = sb.ToString();

                if (regex.IsMatch(command) == true)
                {
                    MatchCollection matches = regex.Matches(command);

                    var planetName = matches[0].Groups["planetName"].Value;
                    var attackType = matches[0].Groups["attackType"].Value;

                    if (planets.Keys.Contains(attackType))
                    {
                        planets[attackType].Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {planets["A"].Count}");
            foreach (var planet in planets["A"].OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {planets["D"].Count}");
            foreach (var planet in planets["D"].OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
