using System;
using System.Linq;
using System.Collections.Generic;
namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contestAndUsers = new Dictionary<string, Dictionary<string, int>>();
            var individual = new Dictionary<string, int>();

            while (true)
            {
                var command = Console.ReadLine().Split(" -> ");

                if(command[0]== "no more time")
                {
                    break;
                }

                var username = command[0];
                var contest = command[1];
                var points = int.Parse(command[2]);

                if (!contestAndUsers.ContainsKey(contest))
                {
                    contestAndUsers.Add(contest, new Dictionary<string, int>());
                    contestAndUsers[contest].Add(username, points);

                    if (individual.ContainsKey(username) && contestAndUsers.ContainsKey(contest))
                    {
                        individual[username] += points;
                    }
                    else
                    {
                        individual.Add(username, points);
                    }

                }
                else if (!contestAndUsers[contest].ContainsKey(username))
                {
                    contestAndUsers[contest].Add(username, points);

                    if (individual.ContainsKey(username) && contestAndUsers.ContainsKey(contest))
                    {
                        individual[username] += points;
                    }
                    else
                    {
                       individual.Add(username, points);
                    }

                }
                if (contestAndUsers[contest][username] < points)
                {
                    contestAndUsers[contest][username] = points;

                    individual[username] = points;
                }
            }
            foreach (var contest in contestAndUsers)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                var counter = 1;
                foreach (var user in contest.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }
            Console.WriteLine("Individual standings:");

            var count = 1;
            foreach (var user in individual.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{count}. {user.Key} -> {user.Value}");
                count++;
            }
        }
    }
}
