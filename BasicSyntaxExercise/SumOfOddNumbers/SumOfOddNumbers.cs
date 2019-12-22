using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int loop = 0;
            int oddNumber = 1;

            while (loop != num)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
                    loop++;
               
            }

           
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
