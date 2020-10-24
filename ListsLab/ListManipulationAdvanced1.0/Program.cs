using System;
using System.Linq;
using System.Collections.Generic;
namespace ListManipulationAdvanced1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                PrintBiggerOrEqualNumbers(command, numbers1);
                PrintBiggerNumbers(command, numbers1);
                PrintingEvenNumbers(command, numbers1);
                PrintingOddNumbers(command, numbers1);
                PrintingSumOfNumbers(command, numbers1);
                PrintSmallerNumbers(command, numbers1);
                PrintSmallerOrEqualNumber(command, numbers1);
            }
        }
        static void PrintBiggerOrEqualNumbers(string command, List<int> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == ">=")
            {
                List<int> result = new List<int>();
                int number = int.Parse(input[2]);

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] >= number)
                    {
                        result.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
        static void PrintBiggerNumbers(string command, List<int> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == ">")
            {
                List<int> result = new List<int>();
                int number = int.Parse(input[2]);

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] > number)
                    {
                        result.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
        static void PrintSmallerOrEqualNumber(string command, List<int> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == "<=")
            {
                List<int> result = new List<int>();
                int number = int.Parse(input[2]);

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] <= number)
                    {
                        result.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }
        static void PrintSmallerNumbers(string command, List<int> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == "<")
            {
                List<int> result = new List<int>();
                int number = int.Parse(input[2]);

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] < number)
                    {
                        result.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", result));
            }

        }
        static void PrintingSumOfNumbers(string command, List<int> numbers1)
        {
            if (command == "GetSum")
            {
                int sum = numbers1.Sum();
                Console.WriteLine(sum);
            }
        }
        static void PrintingOddNumbers(string command, List<int> numbers1)
        {
            if (command == "PrintOdd")
            {
                List<int> oddNumbers = new List<int>();

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] % 2 == 1)
                    {
                        oddNumbers.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", oddNumbers));
            }
        }
        static void PrintingEvenNumbers(string command, List<int> numbers1)
        {
            if (command == "PrintEven")
            {
                List<int> evenNumbers = new List<int>();

                for (int i = 0; i < numbers1.Count; i++)
                {
                    if (numbers1[i] % 2 == 0)
                    {
                        evenNumbers.Add(numbers1[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", evenNumbers));
            }
        }
    }
}
