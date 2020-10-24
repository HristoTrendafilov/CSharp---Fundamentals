using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^[A-Za-z0-9]+[A-Za-z.\-_0-9]*@[A-Za-z-]+(\.[a-z]+)+$");
            var text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);

            foreach (var email in matches)
            {
                Console.WriteLine(email.ToString());
            }
        }
    }
}
