using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            
          
            int counter = 0;
            int spiceMined = 0;

            while (startingYield >= 100)
            {
                spiceMined += startingYield;
                spiceMined -= 26;
                startingYield -= 10;
                counter++;
            }
            if (spiceMined != 0)
            {
                spiceMined -= 26;
            }
            Console.WriteLine(counter);
            Console.WriteLine(spiceMined);
        }
    }
}
