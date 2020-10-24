using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace StringManipulatorFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }
                else if(command[0]== "Translate")
                {
                    var character = command[1];
                    var replacement = command[2];

                   inputString = inputString.Replace(character, replacement);
                    Console.WriteLine(inputString);
                }
                else if(command[0]== "Includes")
                {
                    var str = command[1];
                    bool stringIncludes = inputString.Contains(str);

                    Console.WriteLine(stringIncludes);
                }
                else if (command[0] == "Start")
                {
                    var str = command[1];
                    bool stringStarts = inputString.StartsWith(str);

                    Console.WriteLine(stringStarts);
                }
                else if(command[0]== "Lowercase")
                {
                    inputString = inputString.ToLower();
                    Console.WriteLine(inputString);
                }
                else if(command[0]== "FindIndex")
                {
                    var character = command[1];
                    var lastIndex = inputString.LastIndexOf(character);

                    Console.WriteLine(lastIndex);
                }
                else if(command[0]== "Remove")
                {
                    var startIndex = int.Parse(command[1]);
                    var count = int.Parse(command[2]);

                   inputString = inputString.Remove(startIndex, count);

                    Console.WriteLine(inputString);
                }
            }
        }
    }
}
