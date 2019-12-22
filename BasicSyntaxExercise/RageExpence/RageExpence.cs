using System;

namespace RageExpence
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displeyPrice = double.Parse(Console.ReadLine());

            int trashedHeadsetCount = 0;
            int trashedMouseCount = 0;
            int trashedKeyboardCount = 0;
            int trashedDispleyCount = 0;

            for(int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadsetCount++;
                }
                if (i % 3 == 0)
                {
                    trashedMouseCount++;
                }
                if (i % 6 == 0)
                {
                    
                    trashedKeyboardCount++;
                }
                if (i%12==0)
                {
                    trashedDispleyCount++;
                }
            }
            double totalSum = (headsetPrice * trashedHeadsetCount) + (mousePrice * trashedMouseCount) + (keyboardPrice * trashedKeyboardCount) + (displeyPrice * trashedDispleyCount);
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");

        }
    }
}
