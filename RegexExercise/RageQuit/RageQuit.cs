using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().ToUpper();
            var print = new StringBuilder();
            var totalSymbols = string.Empty;

            var regex = new Regex(@"([0-9]+)|([^0-9]+)");
            MatchCollection matches = regex.Matches(command);

            for (int i = 0; i < matches.Count; i++)
            {
                var current = matches[i].ToString();

                if (current.All(char.IsDigit))
                {
                    var input = matches[i].ToString();
                    var number = Convert.ToInt32(input);

                    for (int j   = 0; j < number; j++)
                    {
                        print.Append(matches[i - 1]);
                    }
                }
                else
                {
                    foreach (var item in matches[i].ToString())
                    {
                        if (!totalSymbols.Contains((char)(item)))
                        {
                           totalSymbols += (char)(item);
                        }

                    }
                }
            }
            var count = print.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(print.ToString());
        }
    }
}
