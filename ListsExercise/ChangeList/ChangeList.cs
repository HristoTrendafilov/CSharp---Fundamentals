using System;
using System.Linq;
using System.Collections.Generic;
namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
    {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.RemoveAt(i);
                            i -= 1;
                        }
                    }
                }
                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    numbers.Insert(index, element);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
