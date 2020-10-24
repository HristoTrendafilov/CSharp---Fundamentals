using System;
using System.Linq;
using System.Collections.Generic;
namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                AddingNumber(command, numbers1);
                RemovingNumbers(command, numbers1);
                RemovingNumbersAt(command, numbers1);
                InsertingNumbers(command, numbers1);

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers1));
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
                numbers1.Insert(index,number);
            }
        }
    }
}
