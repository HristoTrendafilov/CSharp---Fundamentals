using System;
using System.Linq;
using System.Collections.Generic;
namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerAndPosition = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var command = Console.ReadLine();

                if(command== "Season end")
                {
                    break;
                }
                else if (command.Contains("->"))
                {
                    var command1 = command.Split(" -> ");
                    var player = command1[0];
                    var position = command1[1];
                    var skill = int.Parse(command1[2]);

                    if (!playerAndPosition.ContainsKey(player))
                    {
                        playerAndPosition.Add(player, new Dictionary<string, int>());
                        playerAndPosition[player].Add(position, skill);
                    }
                    else
                    {
                        if (!playerAndPosition[player].ContainsKey(position))
                        {
                            playerAndPosition[player].Add(position, skill);
                        }
                        if (playerAndPosition[player][position] < skill)
                        {
                            playerAndPosition[player][position] = skill;
                        }
                    }
                }
                else if (command.Contains("vs"))
                {
                    var command1 = command.Split("vs");
                    var player1 = command[0].ToString();
                    var player2 = command[1].ToString();

                    if(playerAndPosition.ContainsKey(player1) && playerAndPosition.ContainsKey(player2))
                    {
                      
                    }

                }

            }
        }
    }
}
