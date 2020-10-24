using System;
using System.Linq;
using System.Collections.Generic;
namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i <= Math.Min(deck1.Count,deck2.Count); i++)
            {
                if (Math.Min(deck1.Count, deck2.Count) == 0)
                {
                    break;
                }
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);

                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else if (deck1[0] < deck2[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);

                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                else if (deck2[0] == deck1[0])
                {
                    deck1.RemoveAt(0);
                    deck2.RemoveAt(0);
                }
                i--;
                Math.Min(deck1.Count, deck2.Count);
            }
            if (deck1.Count > deck2.Count)
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
        }
    }
}
