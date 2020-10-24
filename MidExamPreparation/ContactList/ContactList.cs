using System;
using System.Linq;
using System.Collections.Generic;
namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "Add")
                {
                    string contact = command[1];

                    if (!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                    }
                    else if (contacts.Contains(contact))
                    {
                        int index = int.Parse(command[2]);

                        if (index>=0 && index <= contacts.Count)
                        {
                            contacts.Insert(index, contact);
                        }
                    }
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index <= contacts.Count-1)
                    {
                        contacts.RemoveAt(index);
                    }
                }
                else if (command[0] == "Export")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    //check here next!
                    if (startIndex<contacts.Count)
                    {
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        for (int i = startIndex; i < count; i++)
                        {
                            if (i == contacts.Count)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write($"{contacts[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if (command[1] == "Normal")
                {
                    Console.Write("Contacts: ");
                    Console.Write(string.Join(" ",contacts));
                    break;
                }
                else if (command[1] == "Reversed")
                {
                    contacts.Reverse();
                    Console.Write("Contacts: ");
                    Console.Write(string.Join(" ",contacts));
                    break;
                }
            }
        }
    }
}
