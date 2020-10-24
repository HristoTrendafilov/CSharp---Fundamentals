using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesAndPoints = new Dictionary<string, int>();
            var languageAndMembers = new Dictionary<string, int>();

            while (true)
            {
                var command = Console.ReadLine().Split("-");

                if(command[0]== "exam finished")
                {
                    break;
                }
                if (command[1] == "banned")
                {
                    namesAndPoints.Remove(command[0]);
                    continue;
                }
                var username = command[0];
                var language = command[1];
                var points = int.Parse(command[2]);

                if(namesAndPoints.ContainsKey(username)&& namesAndPoints[username] < points)
                {
                    namesAndPoints[username] = points;
                    languageAndMembers[language]++;
                }
                else if(!namesAndPoints.ContainsKey(username))
                {
                    namesAndPoints.Add(username, points);
                }
                if (languageAndMembers.ContainsKey(language))
                {
                    languageAndMembers[language]++;
                }
                else
                {
                    languageAndMembers.Add(language, 1);
                }
            }
            Console.WriteLine("Results:");
            foreach (var username in namesAndPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{username.Key} | {username.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in languageAndMembers.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
