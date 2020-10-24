using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AnimalSanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"n:(?<name>[^;]+);t:(?<kind>[^;]+);c--(?<country>[A-Za-z\s]*)$");
            var counter = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < counter; i++)
            {
                var animal = Console.ReadLine();

                if (regex.IsMatch(animal))
                {
                    var name = string.Empty;
                    var kind = string.Empty;
                    MatchCollection matches = regex.Matches(animal);
                    var animalName = matches[0].Groups["name"].Value;
                    foreach (var character in animalName)
                    {
                        if (char.IsWhiteSpace(character) || char.IsLetter(character))
                        {
                            name += character;
                        }
                        else if (char.IsDigit(character))
                        {
                            sum += (int)(character - '0');
                        }
                    }
                    var animalKind = matches[0].Groups["kind"].Value;
                    foreach (var character in animalKind)
                    {
                        if (char.IsWhiteSpace(character) || char.IsLetter(character))
                        {
                            kind += character;
                        }
                        else if (char.IsDigit(character))
                        {
                            sum += (int)(character - '0');
                        }
                    }
                    var animalCountry = matches[0].Groups["country"].Value;
                    Console.WriteLine($"{name} is a {kind} from {animalCountry}");
                }
            }
            Console.WriteLine($"Total weight of animals: {sum}KG");
        }
    }
}
