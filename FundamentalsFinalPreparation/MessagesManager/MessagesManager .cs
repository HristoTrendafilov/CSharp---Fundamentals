using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernameAndMesseges = new Dictionary<string, Dictionary<int, int>>();
            var capacity = Console.ReadLine();

            while (true)
            {
                var command = Console.ReadLine().Split("=");

                if(command[0]== "Statistics")
                {
                    break;
                }
                else if(command[0]== "Add")
                {
                    var username = command[1];
                    var sent = int.Parse(command[2]);
                    var received = int.Parse(command[3]);

                    if (!usernameAndMesseges.ContainsKey(username))
                    {
                        usernameAndMesseges.Add(username, new Dictionary<int, int>());
                        usernameAndMesseges[username].Add(sent, received);
                    }
                }
                else if(command[0]== "Message")
                {
                    var sender = command[1];
                    var receiver = command[2];

                    if(usernameAndMesseges.ContainsKey(sender) && usernameAndMesseges.ContainsKey(receiver))
                    {
                        var senderCurrent = 0;
                        var senderValue = 0;

                        var receiverCurrent = 0;
                        var receiverValue = 0;
                        foreach (var item in usernameAndMesseges[sender])
                        {
                             senderCurrent =(item.Key+1);
                             senderValue = item.Value;
                        }
                        foreach (var item in usernameAndMesseges[receiver])
                        {
                            receiverCurrent = item.Key;
                            receiverValue = item.Value+1;
                        }
                        usernameAndMesseges[sender].Clear();
                        usernameAndMesseges[receiver].Clear();

                        usernameAndMesseges[sender].Add(senderCurrent, senderValue);
                        usernameAndMesseges[receiver].Add(receiverCurrent, receiverValue);

                        foreach (var item in usernameAndMesseges[sender])
                        {
                            if (item.Key >= 10 || item.Value >= 10)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                usernameAndMesseges.Remove(sender);
                            }
                        }
                        foreach (var item in usernameAndMesseges[receiver])
                        {
                            if (item.Key >= 10 || item.Value >= 10)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                usernameAndMesseges.Remove(receiver);
                            }
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

            foreach (var item in usernameAndMesseges.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");
            }
        }
    }
}
