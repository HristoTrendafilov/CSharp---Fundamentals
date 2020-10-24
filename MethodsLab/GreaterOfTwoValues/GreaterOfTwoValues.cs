using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            ReturnGreaterInput(type, input1, input2);
        }
        static void ReturnGreaterInput(string type,string input1,string input2)
        {
            if (type == "int")
            {
               int result1 = int.Parse(input1);
               int result2 = int.Parse(input2);

                if (result1>result2)
                {
                    Console.WriteLine(result1);
                }
                else
                {
                    Console.WriteLine(result2);
                }
            }
            else if (type == "char")
            {
                char result1 = input1[0];
                char result2 = input2[0];
                
                if (result1 > result2)
                {
                    Console.WriteLine(result1);
                }
                else
                {
                    Console.WriteLine(result2);
                }
            }
            else if (type == "string")
            {
                int sum1 = 0;
                int sum2 = 0;

                foreach (var element in input1)
                {
                    sum1 += (int)element;                   
                }
                foreach (var element in input2)
                {
                    sum2 += (int)element;
                }

                if (sum1 > sum2)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input2);
                }
            }
        }
    }
}
