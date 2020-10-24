using System;
using System.Linq;
using System.Collections.Generic;
namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().ToArray().SelectMany(x => x.ToCharArray()).ToArray();

            var textToChara = new Dictionary<char, int>();

            foreach (var character in text)
            {
                if (!textToChara.Keys.Contains(character))
                {
                    textToChara.Add(character,1);
                }
                else
                {
                    textToChara[character]++;
                }
            }
            foreach (var word in textToChara)
            {
                char ch = word.Key;
                int count = word.Value;

                Console.WriteLine($"{ch} -> {count}");
            }
        }
    }
}
