using System;

namespace BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursS = 0;



            int totalMinutes = (hours * 60) + minutes+30;
            while (totalMinutes > 60)
            {
                hoursS += 1;
                totalMinutes -= 60;
            }
            if (hoursS >23 )
            {
                hoursS = 0;
            }
            if (totalMinutes < 10)
            {
                Console.WriteLine($"{hoursS}:0{totalMinutes}");

            }
            else
            {
                Console.WriteLine($"{hoursS}:{totalMinutes}");
            }
        }
    }
}
