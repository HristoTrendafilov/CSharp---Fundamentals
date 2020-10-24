using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace TheIsleofManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"([#$%*&])(?<name>[A-Za-z]+)\1=(?<lenght>\d+)!!(?<code>.+)$");

            while (true)
            {
                var command = Console.ReadLine();

                if (regex.IsMatch(command))
                {
                    MatchCollection matches = regex.Matches(command);
                    var name = matches[0].Groups["name"].Value;
                    var lenght= int.Parse(matches[0].Groups["lenght"].Value);
                    var code = matches[0].Groups["code"].Value;
                    var realCode = string.Empty;

                    if (lenght == code.Length)
                    {
                        foreach (var character in code)
                        {
                            realCode += (char)(character + lenght);
                        }
                        Console.WriteLine($"Coordinates found! {name} -> {realCode}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
