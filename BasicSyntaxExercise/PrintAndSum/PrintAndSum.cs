using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = num1; i<= num2; i++)
            {
                totalSum += i;
                Console.Write($"{i} ");
            }
           
            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");
            
        }
    }
}
