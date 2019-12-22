using System;
using System.Linq;
namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum1 = numbers[i];

                for (int j = i+1; j < numbers.Length; j++)
                {
                    int currentNum2 = numbers[j];
                    if (currentNum1 + currentNum2 == num)
                    {
                        Console.WriteLine($"{currentNum1} {currentNum2}");
                    }
                }
            }

        }
    }
}
