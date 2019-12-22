using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers= double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            int students6 = students;
            double midStudents = students * 0.10;
            double totalStudents =Math.Ceiling(students + midStudents);
            int discountBelt = 0;
          
            for(int i = 1; i <= students; i++)
            {
                discountBelt = students6;
               
                if (i % 6 == 0)
                {
                     discountBelt =students6 -= 1;
                }
            }

            double totalPrice = priceLightsabers * (totalStudents) + (priceRobes * students) + (priceBelts *discountBelt );

            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-amountOfMoney:f2}lv more.");
            }
        }
    }
}
