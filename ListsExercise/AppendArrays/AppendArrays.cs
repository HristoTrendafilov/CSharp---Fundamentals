using System;
using System.Linq;
using System.Collections.Generic;
namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> number = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> result = new List<int>();

            foreach (var str in number)
            {
                result.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList());
                                           
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
