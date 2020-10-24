using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var actualStr = string.Empty;
            var str = new StringBuilder();

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "End")
                {
                    break;
                }
                else if(command[0]=="Add")
                {
                    var str1 = command[1];
                    str.Append(str1);
                    actualStr = str.ToString();
                }
                else if (command[0] == "Upgrade")
                {
                   var ch= Convert.ToChar(command[1]);

                    foreach (var character in actualStr)
                    {
                        if (character == ch)
                        {
                            str.Replace(character, (char)(character + 1));
                        }
                    }
                    actualStr = str.ToString();
                }
                else if (command[0] == "Print")
                {
                    Console.WriteLine(actualStr);
                }
                else if (command[0] == "Index")
                {
                    var ch = Convert.ToChar(command[1]);

                    if (!actualStr.Contains(ch))
                    {
                        Console.WriteLine("None");
                        continue;
                    }

                    for (int i = 0; i < actualStr.Length; i++)
                    {
                        if (actualStr[i] == ch)
                        {
                            Console.Write($"{i} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "Remove")
                {
                    var str1 = command[1];

                    while (actualStr.Contains(str1))
                    {
                        actualStr=actualStr.Remove(actualStr.IndexOf(str1), str1.Length);
                    }
                }
            }
        }
    }
}