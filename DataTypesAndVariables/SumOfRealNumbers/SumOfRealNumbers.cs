﻿using System;

namespace SumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int couter = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < couter; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine((sum));
           
        }
    }
}
