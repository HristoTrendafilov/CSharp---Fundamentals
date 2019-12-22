using System;
using System.Linq;
namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isFalse = false;

            for (int i = 0; i < numbers1.Length; i++)
            {
                sum += numbers1[i];
                if (numbers1[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isFalse = true;
                    break;
                }
                
            }
            if (!isFalse)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
            

        }
    }
}
