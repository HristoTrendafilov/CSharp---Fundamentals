using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "add")
            {
                AddNumbers();
            }
            else if (command == "multiply")
            {
                MultiplyNumbers();
            }
            else if (command == "substract")
            {
                SubstractNumbers();
            }
            else
            {
                DivideNumbers();
            }
        }
        static void AddNumbers()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine(result);
        }
        static void MultiplyNumbers()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 * number2;
            Console.WriteLine(result);
        }
        static void SubstractNumbers()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 - number2;
            Console.WriteLine(result);
        }
        static void DivideNumbers()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 / number2;
            Console.WriteLine(result);
        }
    }
}
