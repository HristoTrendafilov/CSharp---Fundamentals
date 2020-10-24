using System;
using System.Linq;
using System.Collections.Generic;
namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine();

                if(command == "Lumpawaroo")
                {
                    break;
                }
                else if (command.Contains("|") )
                {
                    var commandArray = command.Split(" | ");
                    var side = commandArray[0];
                    var user = commandArray[1];

                    if (!forceUsers.Keys.Contains(side)&& !forceUsers.Values.Any(x=>x.Contains(user)))
                    {
                        forceUsers.Add(side, new List<string>());
                        forceUsers[side].Add(user);
                    }
                    else if (!forceUsers.Values.Any(x=>x.Contains(user)))
                    {
                        forceUsers[side].Add(user);
                    }
                }
                else if (command.Contains("->"))
                {
                    var commandArray = command.Split(" -> ");
                    var side = commandArray[1];
                    string user = commandArray[0];

                    if (forceUsers.Values.Any(x=>x.Contains(user)))
                    {
                        foreach (var item in forceUsers)
                        {
                            if (item.Value.Contains(user))
                            {
                                item.Value.Remove(user);

                            }
                        }
                        forceUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        forceUsers[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
            }
            foreach (var user in forceUsers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (user.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {user.Key}, Members: {user.Value.Count}");

                    foreach (var item in user.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
            }
        }
    }
}
