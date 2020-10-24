using System;

namespace TheSmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            PrintingSmallestNumber(number1, number2, number3);
        }
        static void PrintingSmallestNumber(int number1,int number2,int number3)
        {
            int smallestNumber = 0;

            if(number1<number2 && number1 < number3)
            {
                smallestNumber = number1;
                Console.WriteLine(smallestNumber);
                return;
            }
            if (number2 < number1 && number2 < number3)
            {
                smallestNumber = number2;
                Console.WriteLine(number2);
                return;
            }
            if (number3 < number1 && number3 < number2)
            {
                smallestNumber = number3;
                Console.WriteLine(number3);
                return;
            }
        }
    }
}
