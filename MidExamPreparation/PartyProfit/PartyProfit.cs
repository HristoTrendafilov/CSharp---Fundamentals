using System;
using System.Linq;
using System.Collections.Generic;
namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coinsEarned = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                coinsEarned += 50;
                coinsEarned -= 2 * partySize;
                if (i % 3 == 0)
                {
                    coinsEarned -= partySize * 3;
                }
                if (i % 5 == 0)
                {
                    coinsEarned += 20 * partySize;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    coinsEarned -= 2 * partySize;
                }

            }

            int profitForOnePerson = coinsEarned / partySize;
            Console.WriteLine($"{partySize} companions received {profitForOnePerson} coins each.");
        }
    }
}
