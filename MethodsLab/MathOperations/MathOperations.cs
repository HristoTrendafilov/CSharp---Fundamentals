using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            Calculate(number1, @operator, number2);
            
        }
        static void Calculate(int number1,string @operator,int number2)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
            }
            Console.WriteLine(result);
            
        }
    }
}
