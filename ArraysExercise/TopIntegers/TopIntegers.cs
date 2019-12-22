using System;
using System.Linq;
namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNum = numbers[i];
                bool isTop = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int otherNumber = numbers[j];

                    if (currentNum > otherNumber)
                    {
                        Console.Write(currentNum + " ");
                        break;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }

                }
            }
            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
