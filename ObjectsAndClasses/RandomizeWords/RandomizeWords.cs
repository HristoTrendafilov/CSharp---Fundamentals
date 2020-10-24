using System;
using System.Linq;
using System.Collections.Generic;
namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine().Split().ToList();

            Random rnd = new Random();

            for (int i = 0; i < sentence.Count; i++)
            {
                var randomIndex = rnd.Next(0, sentence.Count);

                var randomElement = sentence[randomIndex];
                var element = sentence[i];

                sentence[randomIndex] = element;
                sentence[i] = randomElement;
            }
            foreach (var number in sentence)
            {
                Console.WriteLine(number);
            }
        }
    }
}
