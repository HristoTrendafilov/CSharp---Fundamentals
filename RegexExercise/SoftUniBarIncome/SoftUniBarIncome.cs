using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$");
            var command = Console.ReadLine();
            double sum = 0;

            while (command!="end of shift")
            {
                if (regex.IsMatch(command) == true)
                {
                    MatchCollection matches = regex.Matches(command);

                    var name = matches[0].Groups["name"].Value;
                    var product = matches[0].Groups["product"].Value;
                    var count = double.Parse(matches[0].Groups["count"].Value);
                    var price = double.Parse(matches[0].Groups["price"].Value);

                    sum += count * price;
                    Console.WriteLine($"{name}: {product} - {count*price:f2}");

                }
                command = Console.ReadLine();
            }
   
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
