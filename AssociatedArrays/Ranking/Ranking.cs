using System;
using System.Linq;
using System.Collections.Generic;
namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestAndPassword = new Dictionary<string, string>();

            while (true)
            {
                var command = Console.ReadLine().Split(":");

                if(command[0]== "end of contests")
                {
                    break;
                }
                var contest = command[0];
                var password = command[1];

                contestAndPassword.Add(contest, password);
            }
            var userAndPoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var command = Console.ReadLine().Split("=>");

                if (command[0]== "end of submissions")
                {
                    break;
                }
                var contest = command[0];
                var password= command[1];
                var username= command[2];
                var points= int.Parse(command[3]);

                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (userAndPoints.ContainsKey(username) && userAndPoints[username].ContainsKey(contest) && userAndPoints[username][contest] < points)
                    {
                        userAndPoints[username][contest] = points;
                    }
                    else
                    {
                        if (userAndPoints.ContainsKey(username) && !userAndPoints[username].ContainsKey(contest))
                        {
                            userAndPoints[username].Add(contest, points);
                        }
                        else if(!userAndPoints.ContainsKey(username))
                        {
                             userAndPoints.Add(username,new Dictionary<string, int>());
                             userAndPoints[username].Add(contest, points);
                        }
                    }
                }
            }
            var winner = string.Empty;
            var winnerPoints = 0;

            foreach (var winner1 in userAndPoints)
            {
                if(winnerPoints< winner1.Value.Sum(x => x.Value))
                {
                    winner = winner1.Key;
                    winnerPoints = winner1.Value.Sum(x => x.Value);
                }
            }
            Console.WriteLine($"Best candidate is {winner} with total {winnerPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var user in userAndPoints.OrderBy(x=>x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var item in user.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
