using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            ReturnInteger(type, input);
            ReturnRealNumber(type, input);
            ReturnString(type, input);
        }
        static void ReturnInteger(string type,string input)
        {
            if (type == "int")
            {
                int number = int.Parse(input);
                int result = number * 2;
                Console.WriteLine(result);
            }
        }
        static void ReturnRealNumber(string type,string input)
        {
            if (type == "real")
            {
                double number = double.Parse(input);
                double result = number * 1.5;
                Console.WriteLine($"{result:f2}");
            }
        }
        static void ReturnString(string type,string input)
        {
            if (type == "string")
            {
                Console.WriteLine($"${input}$");
            }
        }
    }
}
