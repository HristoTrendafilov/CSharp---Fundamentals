using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace newOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernameAndMesseges = new Dictionary<string, int>();
            var capacity = Console.ReadLine();

            while (true)
            {
                var command = Console.ReadLine().Split("=");

                if (command[0] == "Statistics")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    var username = command[1];
                    var total = int.Parse(command[2]) + int.Parse(command[3]);

                    if (!usernameAndMesseges.ContainsKey(username))
                    {
                        usernameAndMesseges.Add(username, total);
                    }
                }
                else if (command[0] == "Message")
                {
                    var sender = command[1];
                    var receiver = command[2];

                    if (usernameAndMesseges.ContainsKey(sender) && usernameAndMesseges.ContainsKey(receiver))
                    {
                        usernameAndMesseges[sender]++;
                        usernameAndMesseges[receiver]++;

                        if (usernameAndMesseges[sender] >= 10)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            usernameAndMesseges.Remove(sender);
                        }
                        if (usernameAndMesseges[receiver] >= 10)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            usernameAndMesseges.Remove(receiver);
                        }
                    }
                }
                else if (command[0] == "Empty")
                {
                    var username = command[1];

                    if (username == "All")
                    {
                        usernameAndMesseges.Clear();
                    }
                    else if (usernameAndMesseges.ContainsKey(username))
                    {
                        usernameAndMesseges.Remove(username);
                    }
                }
            }
            Console.WriteLine($"Users count: {usernameAndMesseges.Keys.Count}");
            foreach (var item in usernameAndMesseges.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
