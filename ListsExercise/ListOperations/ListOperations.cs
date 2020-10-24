using System;
using System.Linq;
using System.Collections.Generic;
namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                
                List<string> command = input.Split().ToList();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if (command[0] == "Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);
                    if (number > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    numbers.RemoveAt(number);
                }
                else if (command[1] == "left")
                {
                    int number = int.Parse(command[2]);
             
                    for (int i = 0; i < number; i++)
                    {
                        int firstNumber = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNumber);
                    }
                }
                else if (command[1] == "right")
                {
                    int number = int.Parse(command[2]);
                
                    for (int i = 0; i < number; i++)
                    {
                        int lastNumber = numbers[numbers.Count-1];
                        numbers.RemoveAt(numbers.Count-1);
                        numbers.Insert(0, lastNumber);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
