﻿using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstChar = Console.ReadLine();
            string secondChar = Console.ReadLine();
            string thirdChar = Console.ReadLine();

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}
