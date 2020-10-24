using System;
using System.Linq;
using System.Collections.Generic;
namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine().Split().Select(double.Parse).ToList();
            double leftDriverSum = 0;
            double rightDriverSum = 0;

            for (int i = 0; i < number.Count/2; i++)
            {
                if (number[i] == 0)
                {
                    leftDriverSum *= 0.8;
                }
                else
                {
                    leftDriverSum += number[i];
                }
                
            }
            for (int i = number.Count-1; i >=number.Count/2+1; i--)
            {
                if (number[i] == 0)
                {
                    rightDriverSum *= 0.8;
                }
                else
                {
                    rightDriverSum += number[i];
                }
            }
            if (leftDriverSum < rightDriverSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftDriverSum}");
            }
            else if(rightDriverSum<leftDriverSum)
            {
                Console.WriteLine($"The winner is right with total time: {rightDriverSum}");
            }
        }
    }
}
