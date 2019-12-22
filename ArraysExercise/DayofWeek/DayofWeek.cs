using System;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] day = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",               
            "Saturday",                 
            "Sunday"};

            if(dayOfWeek>=1 && dayOfWeek <= 7)
            {
                Console.WriteLine(day[dayOfWeek - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    
    }
}
