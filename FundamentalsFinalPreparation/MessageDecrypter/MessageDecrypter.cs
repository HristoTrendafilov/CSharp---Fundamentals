using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^([$|%])(?<tag>[A-Z][a-z]{2,})\1: (\[(?<first>\d+)]\|)(\[(?<second>\d+)]\|)(\[(?<third>\d+)]\|)$");
            var counter = int.Parse(Console.ReadLine());
            var correctText = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                var messege = Console.ReadLine();

                if (regex.IsMatch(messege))
                {
                    MatchCollection matches = regex.Matches(messege);
                    var firstLetterNumber = int.Parse(matches[0].Groups["first"].Value);
                    var secondLetterNumber = int.Parse(matches[0].Groups["second"].Value);
                    var thirdLetterNumber = int.Parse(matches[0].Groups["third"].Value);
                    var name = matches[0].Groups["tag"].Value;

                    var firstLetter = (char)firstLetterNumber;
                    var secondLetter = (char)secondLetterNumber;
                    var thirdLetter = (char)thirdLetterNumber;

                    correctText += firstLetter;
                    correctText += secondLetter;
                    correctText += thirdLetter;

                    Console.WriteLine($"{name}: {correctText}");
                    correctText = string.Empty;
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
