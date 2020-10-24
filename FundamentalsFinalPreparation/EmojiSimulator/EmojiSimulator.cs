using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace EmojiSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
            var numbersSum = numbers.Sum();

            var regex = new Regex(@"(?<=\s)\:(?<emoji>[a-z]{4,})\:(?=\s|[,.!?])");
            MatchCollection matches = regex.Matches(text);
           
            var correctEmojis = new List<string>();

            var sum = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                if (matches[i].Groups["emoji"].Value.Length >= 4)
                {
                    correctEmojis.Add(matches[i].Groups["emoji"].Value);
                }
            }

            for (int i = 0; i < correctEmojis.Count; i++)
            {
                var singleEmoji = correctEmojis[i].ToCharArray();

                foreach (var emoji in singleEmoji)
                {
                    sum += (int)emoji;
                }
            }
            for (int i = 0; i < correctEmojis.Count; i++)
            {
                var singleEmoji = correctEmojis[i].Sum(x=>x);

                if (singleEmoji == numbersSum)
                {
                    sum *= 2;
                }
            }
            if (correctEmojis.Count > 0)
            {
                var final = new List<string>();

                for (int i = 0; i < matches.Count; i++)
                {
                    if (matches[i].Groups["emoji"].Value.Length >= 4)
                    {
                        final.Add(matches[i].ToString().Replace(" ", string.Empty));
                    }
                }
                Console.Write("Emojis found: ");
                Console.WriteLine(string.Join(", ", final));
            }
            Console.WriteLine($"Total Emoji Power: {sum}");
        }
    }
}
