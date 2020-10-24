using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new[] { ',', ' ' },
                                StringSplitOptions.RemoveEmptyEntries);
            var demonStatistic = new SortedDictionary<string, Dictionary<double, double>>();

            for (int i = 0; i < names.Length; i++)
            {
                var regexName = new Regex(@"[^, ]");

                if (regexName.IsMatch(names[i]) == true)
                {
                    double demonHealth = 0;
                    double demonDamage = 0;

                    var regexHealth = new Regex((@"[^0-9 +\-*,\/.]"));
                    MatchCollection matches = regexHealth.Matches(names[i]);

                    foreach (var character in matches)
                    {
                        var characterString = character.ToString();

                        foreach (var item in characterString)
                        {
                            demonHealth += (int)(item);
                        }
                    }

                    var regexDemage = new Regex(@"[+-]?[\d+|\d+.\d+]+");
                    MatchCollection demageMatch = regexDemage.Matches(names[i]);

                    foreach (var number in demageMatch)
                    {
                        var damageNumber = number.ToString();
                        demonDamage += Convert.ToDouble(damageNumber);
                    }

                    var multiplyOrReduceNumbers = new Regex(@"[\/*]");
                    MatchCollection matchesMultiplyOrReduce = multiplyOrReduceNumbers.Matches(names[i]);

                    foreach (var item in matchesMultiplyOrReduce)
                    {
                        var damageNumber = item.ToString();

                        if (damageNumber == "*")
                        {
                            demonDamage *= 2;
                        }
                        else if (damageNumber == "/")
                        {
                            demonDamage /= 2;
                        }
                    }
                    demonStatistic.Add(names[i], new Dictionary<double, double>());
                    demonStatistic[names[i]].Add(demonHealth, demonDamage);
                }
            }
            foreach (var demon in demonStatistic)
            {
                Console.Write($"{demon.Key} - ");

                foreach (var item in demon.Value)
                {
                    Console.Write($"{item.Key} health, {item.Value:f2} damage");
                }
                Console.WriteLine();
            }
        }
    }
}
