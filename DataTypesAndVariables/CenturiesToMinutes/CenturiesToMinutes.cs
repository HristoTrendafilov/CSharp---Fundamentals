using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double century = double.Parse(Console.ReadLine());

            double years = century * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
