using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string nameOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;
            double discount = 0.0;
           
            if (nameOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
                if (numberOfPeople >= 30)
                {
                    discount = price * 0.15;
                    price -= discount;
                }
                
            }
            if (nameOfGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
                if (numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }
                
            }
            if (nameOfGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price =15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
                if (numberOfPeople >= 10 && numberOfPeople<=20)
                {
                    discount = price / 0.05;
                    price -= discount;
                }
            }
            double sum = numberOfPeople * price;
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}