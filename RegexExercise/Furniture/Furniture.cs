using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"[>][>](?<type>\w+)[<][<](?<price>\d+\.\d+|\d+)[!](?<quantity>\d+)\b");

            var input = Console.ReadLine();

            var names = new List<string>();
            double sum = 0;

            while (input != "Purchase")
            {

                if (regex.IsMatch(input) == true)
                {
                    MatchCollection matches = regex.Matches(input);
                    names.Add(matches[0].Groups["type"].Value);
                    sum += double.Parse(matches[0].Groups["price"].Value) * double.Parse(matches[0].Groups["quantity"].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (names.Count > 0)
            {
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
