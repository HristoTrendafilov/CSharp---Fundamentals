using System;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigNumber = Console.ReadLine().ToCharArray();
            var smallNumber = decimal.Parse(Console.ReadLine());

            if (smallNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = string.Empty;

            for (int i = bigNumber.Length-1; i > 0; i--)
            {
               var deleting = (bigNumber[i]-48) * smallNumber;
                result += deleting / 10;
            }
            
            Console.WriteLine(result);

            
        }
    }
}
