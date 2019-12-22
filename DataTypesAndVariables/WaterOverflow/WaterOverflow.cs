using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLitres = 255;
            int timesPouringLater = int.Parse(Console.ReadLine());

            int currentLitres = 0;

            for (int i = 0; i < timesPouringLater; i++)
            {
                int pouringLitres = int.Parse(Console.ReadLine());
                currentLitres += pouringLitres;
                if (currentLitres > totalLitres)
                {
                    Console.WriteLine("Insufficient capacity!" );
                    currentLitres -= pouringLitres;
                }
                
            }
            Console.WriteLine(currentLitres);

        }
    }
}
