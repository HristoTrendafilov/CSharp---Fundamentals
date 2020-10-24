using System;
using System.Linq;
using System.Collections.Generic;
namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbers2 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();


            for (int i = 0; i < Math.Max(numbers1.Count, numbers2.Count); i++)
            {
                if (i < Math.Min(numbers1.Count, numbers2.Count))
                {
                    result.Add(numbers1[i]);
                    result.Add(numbers2[i]);
                }
                else if (i > numbers2.Count - 1)
                {
                    result.Add(numbers1[i]);
                }
                else
                {
                    result.Add(numbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
