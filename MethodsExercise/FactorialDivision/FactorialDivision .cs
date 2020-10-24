using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            

            for (double i = number1-1 ; i >= 1;  i--)
            {
                number1 *= i;
                              
            }
            for (double i = number2 - 1; i >= 1; i--)
            {
                number2 *= i;

            }
            double diff = number1 / number2;
            Console.WriteLine($"{diff:f2}");
        }
    }
}
