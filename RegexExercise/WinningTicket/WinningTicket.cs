using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ',', ' ' },
                                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    var regex = new Regex(@"[\@\#\$\^]+");

                    if (regex.IsMatch(tickets[i]))
                    {
                        MatchCollection matches = regex.Matches(tickets[i]);

                        if (matches.Count == 1 && SameCharacter(matches)==true)
                        {
                            var symbol = matches[0].ToString()[0];
                            Console.WriteLine($"ticket \"{matches[0]}\" - 10{symbol} Jackpot!");
                        }
                        else if (matches.Count == 2 && SameCharacter(matches)==true)
                        {
                            var lenght = Math.Min(matches[0].Length, matches[1].Length);

                            if (lenght>=6 && lenght <= 9)
                            {
                                var symbol = matches[0].ToString()[0];
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {lenght}{symbol}");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }

        }
        static bool SameCharacter (MatchCollection matches)
        {
            if (matches.Count == 1)
            {
                if(matches[0].ToString().All(ch => ch == matches[0].ToString()[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (matches.Count == 2)
            {
                if (matches[0].ToString().All(ch => ch == matches[0].ToString()[0])
                && matches[1].ToString().All(ch => ch == matches[1].ToString()[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
