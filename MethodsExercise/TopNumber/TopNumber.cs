using System;
using System.Linq;
namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isOddDigit = false;

            for (int i = 10; i <= number; i++)
            {
                int[] numberToIndex = Array.ConvertAll(i.ToString().ToArray(), x => (int)x - 48);

                for (int j = 0; j < numberToIndex.Length; j++)
                {
                    sum += numberToIndex[j];

                    if (numberToIndex[j] == 1 || numberToIndex[j] == 3 || numberToIndex[j] == 5
                        || numberToIndex[j] == 7 || numberToIndex[j] == 9)
                    {
                        isOddDigit = true;
                    }
                }
                if (sum % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
                isOddDigit = false;
            }
        }
    }
}
