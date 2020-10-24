using System;
using System.Linq;
using System.Collections.Generic;
namespace Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();
            double middleNumber = numbers[numbers.Count / 2];

            for (int i = 0; i < numbers.Count/2; i++)
            {
                
                result.Add(numbers[i] + numbers[numbers.Count - 1-i]);
                
            }
            if (numbers.Count % 2 == 0)
            {
                Console.Write(string.Join(" ", result));
            }
            else
            {
                Console.Write(string.Join(" ", result));
                Console.Write($" {middleNumber}");
            }
            
        }
    }
}
