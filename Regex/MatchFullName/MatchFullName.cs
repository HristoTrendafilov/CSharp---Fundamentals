using System;
using System.Text.RegularExpressions;
namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();

            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

            var matches = regex.Matches(names);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
