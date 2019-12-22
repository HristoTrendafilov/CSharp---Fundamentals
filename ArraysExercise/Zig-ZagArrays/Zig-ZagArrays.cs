using System;
using System.Linq;
namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] first = new int[count];
            int[] second = new int[count];

            for (int i = 0; i < count; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                }
                else
                {
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }

            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
           


              
            
        }
    }
}
