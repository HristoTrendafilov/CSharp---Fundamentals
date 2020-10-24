using System;
using System.Linq;
using System.Collections.Generic;
namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                AddingNumber(command, numbers1);
                RemovingNumbers(command, numbers1);
                RemovingNumbersAt(command, numbers1);
                InsertingNumbers(command, numbers1);
                PrintContainNumber(command, numbers1);
                PrintingEvenNumbers(command, numbers1);
                PrintingOddNumbers(command, numbers1);
                PrintingSumOfNumbers(command, numbers1);
                PrintSmallerNumbers(command, numbers1);
                PrintSmallerOrEqualNumber(command, numbers1);
                PrintBiggerNumbers(command, numbers1);
                PrintBiggerOrEqualNumbers(command, numbers1);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers1));
        }
        static void PrintBiggerOrEqualNumbers(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == ">=")
            {
                List<double> result = new List<double>();
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
        static void PrintBiggerNumbers(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == ">")
            {
                List<double> result = new List<double>();
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
        static void PrintSmallerOrEqualNumber(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Filter" && input[1] == "<=")
            {
                List<double> result = new List<double>();
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
        static void PrintSmallerNumbers(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();
            
            if (input[0]=="Filter" && input[1] == "<")
            {
                List<double> result = new List<double>();
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
        static void PrintingSumOfNumbers(string command, List<double> numbers1)
        {
            if (command == "GetSum")
            {
                double sum = numbers1.Sum();
                Console.WriteLine(sum);
            }
        }
        static void PrintingOddNumbers(string command, List<double> numbers1)
        {
            if (command == "PrintOdd")
            {
                List<double> oddNumbers = new List<double>();

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
        static void PrintingEvenNumbers(string command, List<double> numbers1)
        {
            if (command == "PrintEven")
            {
                List<double> evenNumbers = new List<double>();

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
        static void AddingNumber(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Add")
            {
                int number = int.Parse(input[1]);
                numbers1.Add(number);
            }
        }
        static void RemovingNumbers(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Remove")
            {
                int number = int.Parse(input[1]);
                numbers1.Remove(number);
            }
        }
        static void RemovingNumbersAt(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "RemoveAt")
            {
                int number = int.Parse(input[1]);
                numbers1.RemoveAt(number);
            }
        }
        static void InsertingNumbers(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Insert")
            {
                int number = int.Parse(input[1]);
                int index = int.Parse(input[2]);
                numbers1.Insert(index, number);
            }
        }
        static void PrintContainNumber(string command, List<double> numbers1)
        {
            string[] input = command.Split().ToArray();

            if (input[0] == "Contains")
            {
                int number = int.Parse(input[1]);
                if (numbers1.Contains(number))
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
        }
    }
}
