using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            var regex = new Regex(@"[A-Za-z0-9\s]");
            var gamesAndPrice = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(":"))
                {
                    var dlc = input[i].Split(":");
                    var game = dlc[0];
                    var theDlc= dlc[1];

                    if (gamesAndPrice.ContainsKey(game))
                    {
                        gamesAndPrice[game]+" - {}"
                    }
                }
            }
        }
    }
}
