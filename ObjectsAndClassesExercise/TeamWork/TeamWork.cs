using System;
using System.Collections.Generic;
using System.Linq;
namespace TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<TeamCreator> totalTeams = new List<TeamCreator>();


            int teamCounter = -1;
            bool playerExists = false;

            for (int i = 0; i < teamsCount; i++)
            {
                List<string> user = Console.ReadLine().Split("-").ToList(); 

                string teamName = user[1];
                string userName = user[0];

                var team = new TeamCreator(teamName, userName);

                if (i == 0)
                {
                    totalTeams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {userName}!");
                    teamCounter++;
                    continue;
                }

                for (int j = 0; j < totalTeams.Count; j++)
                {
                    if (userName == totalTeams[j].UserName)
                    {
                        Console.WriteLine($"{userName} cannot create another team!");
                        playerExists = true;
                        break;
                    }
                }
                if (playerExists)
                {
                    playerExists = false;
                    continue;
                }

                if (team.TeamName == totalTeams[teamCounter].TeamName)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else
                {
                    totalTeams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {userName}!");
                    teamCounter++;
                }
            }

            while (true)
            {
                List<string> user = Console.ReadLine().Split("->").ToList();

                if (user[0] == "end")
                {
                    break;
                }

                string teamName = user[1];
                string userName = user[0];
                int teamsCounter = 0;

                for (int i = 0; i < totalTeams.Count; i++)
                {
                    if (teamName == totalTeams[i].TeamName)
                    {
                        for (int j = 0; j < totalTeams.Count; j++)
                        {
                            if (userName == totalTeams[j].UserName)
                            {
                                Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                                playerExists = true;
                                break;
                            }
                        }
                        if (playerExists)
                        {
                            playerExists = false;
                            break;
                        }
                    }
                    teamsCounter++;
                    if (teamsCounter == totalTeams.Count)
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                        break;
                    }
                }
            }
        }
        class TeamCreator
        {
            public TeamCreator(string teamName,string username)
            {
                TeamName = teamName;
                UserName = username;
            }
            public string TeamName { get; set; }
            public string UserName { get; set; }

        }
    }
}
