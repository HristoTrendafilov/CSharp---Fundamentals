using System;
using System.Text.RegularExpressions;
namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers =Console.ReadLine();

            var regex = new Regex(@"[+][3][5][9](-| )[2]\1\d{3}\1\d{4}\b");

            MatchCollection matches = regex.Matches(phoneNumbers);

            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
