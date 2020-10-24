using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordAndDefinition = new Dictionary<string, List<string>>();
            var command = Console.ReadLine().Split(" | ");

            for (int i = 0; i < command.Length; i++)
            {
                var wordArray = command[i].Split(": ");

                if (!wordAndDefinition.ContainsKey(wordArray[0]))
                {
                    var word = wordArray[0];
                    var definition = wordArray[1];

                    wordAndDefinition.Add(word, new List<string>());
                    wordAndDefinition[word].Add(definition);
                }
                else
                {
                    var word = wordArray[0];
                    var definition = wordArray[1];

                    wordAndDefinition[word].Add(definition);
                }

            }
            
            var command2 = Console.ReadLine().Split(" | ");

            for (int i = 0; i < command2.Length; i++)
            {
                var word = command2[i];

                if (wordAndDefinition.ContainsKey(word))
                {
                    Console.WriteLine(word);

                    foreach (var item in wordAndDefinition[word].OrderByDescending(x=>x.Length))
                    {
                        Console.WriteLine($" -{item}");
                    }
                }
            }

            var command3 = Console.ReadLine();

            if (command3 == "List")
            {
                foreach (var item in wordAndDefinition.Keys.OrderBy(x=>x))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
