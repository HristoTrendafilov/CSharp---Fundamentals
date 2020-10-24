using System;
using System.Linq;
namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int trueNumber = Math.Abs(number);


            GetMultipleOfEvenAndOdds(trueNumber);
        }
        static void GetSumOfEvenDigits(int trueNumber)
        {
            int[] numbers = new int[trueNumber.ToString().Length];
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
        }
        static void GetSumOfOddDigits(int trueNumber)
        {
            int[] numbers = new int[trueNumber.ToString().Length];
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddSum += numbers[i];
                }
            }
        }
        static void GetMultipleOfEvenAndOdds(int trueNumber)
        {

            int[] numbers = Array.ConvertAll(trueNumber.ToString().ToArray(), x => (int)x - 48);
            
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    oddSum += numbers[i];
                }
                else
                {
                    evenSum += numbers[i];
                }
            }
            int totalSum = evenSum * oddSum;
            Console.WriteLine(totalSum);
        }
    }
}
