using System;

namespace ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string[] revStr = new string[str.Length];

            for (int i = str.Length-1;i>=0;i--)
            {
                revStr[i] = str[i];
                Console.Write($"{revStr[i]} ");
            }
        }
    }
}
