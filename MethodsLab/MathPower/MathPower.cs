using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            ReturnNumberPower(number, power);
        }
        static void ReturnNumberPower(double number,double power)
        {
            double powerNumber = Math.Pow(number, power);
            Console.WriteLine(powerNumber);

            
           
        }
    }
}
