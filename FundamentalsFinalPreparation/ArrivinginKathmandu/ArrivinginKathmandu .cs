using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ArrivinginKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<code>(.*?)+)$");
            while (true)
            {
                var command = Console.ReadLine();

                if(command== "Last note")
                {
                    break;
                }
                if (regex.IsMatch(command))
                {
                    var decodedName = string.Empty;
                    MatchCollection matches = regex.Matches(command);
                    var name = matches[0].Groups["name"].Value;
                    foreach (var item in name)
                    {
                        if (char.IsLetter(item)||char.IsDigit(item))
                        {
                            decodedName += item;
                        }
                    }
                    var length = int.Parse(matches[0].Groups["length"].Value);
                    var code = matches[0].Groups["code"].Value;

                    if (length == code.Length)
                    {
                        Console.WriteLine($"Coordinates found! {decodedName} -> {code}");
                    }
                    else
                    {
                        Console.WriteLine($"Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine($"Nothing found!");
                }

            }
        }
    }
}
