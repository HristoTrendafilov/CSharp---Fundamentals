using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string char1 = Console.ReadLine();

            for (int i = 0; i < char1.Length; i++)
            {
                if (char.IsLower(char1[i]))
                {
                    Console.WriteLine("lower-case");
                }
                else
                {
                    Console.WriteLine("upper-case");
                }
            }
            
        }



    
    }
}
