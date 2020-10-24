using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            SubstractFromFirstTwoNumbers(number1, number2, number3);
        }
        static void SumOfFirstTwoNumbers(int number1,int number2)
        {
            int sumOfTwoNumbers = number1 + number2;
        }
        static void SubstractFromFirstTwoNumbers(int number1,int number2,int number3)
        {
            int sumOfTwoNumbers = number1 + number2;
            int substract = sumOfTwoNumbers - number3;
            Console.WriteLine(substract);
        }
    }
}
