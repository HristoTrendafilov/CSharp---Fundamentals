using System;
using System.Linq;
using System.Collections.Generic;
namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine().Split().Select(double.Parse).ToList();
            

            
                for (int i = 0; i < number.Count; i++)
                {
                if (i == number.Count - 1)
                {
                    break;
                }
                    if (number[i] == number[i + 1])
                    {
                        number[i] += number[i + 1];                     
                        number.RemoveAt(i+1);
                        i = -1;
                    }
               
                }
            Console.WriteLine(string.Join(" ",number));
            
        }            
    }
}
