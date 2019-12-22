using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            
            
           
            for (int ch = 1; ch <= numbers; ch++)
            {
                int number = ch;
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool isMagicNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", ch, isMagicNumber);
                
            }

        }
    }
}
