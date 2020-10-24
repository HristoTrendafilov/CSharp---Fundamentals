using System;
using System.Linq;
namespace CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                
                int[] condenced = new int[numbers.Length];
                condenced[i] = numbers[i] + numbers[i + 1];
                
                            
                Console.WriteLine(condenced[i]);
                
            }
            Console.WriteLine(numbers[0]);

        }
    }
}
