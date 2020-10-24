using System;
using System.Linq;
using System.Collections.Generic;
namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            string mergedString = string.Empty;

            while (command != "3:1")
            {
                List<string> input = command.Split().ToList();

                if (input[0] == "merge")
                {
                    int startingIndex = int.Parse(input[1]);
                    int staticStartingIndex = startingIndex;
                    int endIndex = int.Parse(input[2]);

                    if (startingIndex > str.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    if (endIndex > str.Count)
                    {
                        for (int i = startingIndex; i <= str.Count-1; i++)
                        {
                            mergedString += str[i];
                        }
                        for (int i = startingIndex; i <= str.Count+1; i++)
                        {
                            str.RemoveAt(staticStartingIndex);
                        }
                    }
                    else
                    {
                        for (int i = startingIndex; i <= endIndex; i++)
                        {
                            mergedString += str[i];
                        }

                        for (int i = startingIndex; i <= endIndex; i++)
                        {
                            str.RemoveAt(staticStartingIndex);
                        }
                    }
                    str.Insert(startingIndex, mergedString);
                    mergedString = string.Empty;
                }
                if (input[0] == "divide")
                {
                    List<string> divided = new List<string>();
                    int index = int.Parse(input[1]);
                    int partitions = int.Parse(input[2]);
                    string dividedWord = str[index];
                    int dividing = dividedWord.Length / partitions;
                    str.RemoveAt(index);

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            divided.Add(dividedWord.Substring(i * dividing));
                        }
                        else
                        {
                            divided.Add(dividedWord.Substring(i * dividing, dividing));
                        }
                    }
                    for (int i = divided.Count-1; i >=0; i--)
                    {
                        str.Insert(index, divided[i]);
                    }
                }
                command = Console.ReadLine(); 
            }
            Console.WriteLine(string.Join(" ",str));
        }
    }
}
