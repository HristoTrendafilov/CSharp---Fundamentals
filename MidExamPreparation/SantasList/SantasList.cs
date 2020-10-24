using System;
using System.Linq;
using System.Collections.Generic;
namespace SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theList = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Finished!")
                {
                    break;
                }

                if (command[0] == "Bad")
                {
                    string kidName = command[1];

                    if (theList.Contains(kidName))
                    {
                        continue;
                    }
                    else
                    {
                        theList.Insert(0, kidName);
                    }
                }
                if (command[0] == "Good")
                {
                    string kidName = command[1];

                    if (theList.Contains(kidName))
                    {
                        theList.RemoveAt(theList.IndexOf(kidName));
                    }
                }
                if (command[0] == "Rename")
                {
                    string oldName = command[1];
                    string newName = command[2];

                    if (theList.Contains(oldName))
                    {
                        int index = theList.IndexOf(oldName);
                        theList[index] = newName;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (command[0] == "Rearrange")
                {
                    string kid = command[1];

                    if (theList.Contains(kid))
                    {
                        int index = theList.IndexOf(kid);
                        theList.RemoveAt(index);
                        theList.Add(kid);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",theList));
        }
    }
}
