using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                var sb = new StringBuilder(command);

                int numberCounter = -1;

                if (command == "find")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < command.Length; i++)
                    {
                        numberCounter++;
                        sb[i] -= (char)number[numberCounter];


                        if (numberCounter==number.Length-1)
                        {
                            numberCounter = -1;
                        }
                    }
                    command = sb.ToString();

                    var endType = command.LastIndexOf("&") - command.IndexOf("&") - 1;
                    var endCoordinates = command.IndexOf(">") - command.IndexOf("<") - 1;

                    var type = command.Substring(command.IndexOf("&") + 1, endType);
                    var coordinates = command.Substring(command.IndexOf("<")+1,endCoordinates);

                    Console.WriteLine($"Found {type} at {coordinates}");
                }
            }
        }
    }
}
