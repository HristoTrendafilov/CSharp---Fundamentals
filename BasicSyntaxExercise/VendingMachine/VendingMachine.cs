using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();


            double totalMoney = 0;

            while (money != "Start")
            {
                double addedMoney = double.Parse(money);
                
                if (addedMoney != 0.1 && addedMoney!=0.2 && addedMoney!=0.5 && addedMoney!=1 && addedMoney!=2)
                {
                    Console.WriteLine($"Cannot accept {addedMoney}");
                    totalMoney -= addedMoney;
                } 
                totalMoney += addedMoney;

                money = Console.ReadLine();
            }
            
            string product1 = Console.ReadLine();
            
            while (product1 != "End")
            {   
                if (product1 != "Nuts" && product1 != "Water" && product1 != "Crisps" && product1 != "Soda" && product1 != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                if (product1== "Nuts")
                {
                    if (totalMoney == 0)
                    {
                        break;
                    }
                    totalMoney -= 2.0;
                    
                    Console.WriteLine("Purchased nuts");

                }
                if (product1 == "Water")
                {
                    if (totalMoney == 0)
                    {
                        break;
                    }
                    totalMoney -= 0.7;
                    
                    Console.WriteLine("Purchased water");

                }
                if (product1 == "Crisps")
                {
                    if (totalMoney == 0)
                    {
                        break;
                    }
                    totalMoney -= 1.5;
                    
                    Console.WriteLine("Purchased crisps");

                }
                if (product1 == "Soda")
                {
                    if (totalMoney == 0)
                    {
                        break;
                    }
                    totalMoney -= 0.8;
                    
                    Console.WriteLine("Purchased soda");

                }
                if (product1 == "Coke")
                {
                    if (totalMoney == 0)
                    {
                        break;
                    }
                    totalMoney -= 1.0;
                    
                    Console.WriteLine("Purchased coke");

                }
                product1 = Console.ReadLine();
            }
            
            if (totalMoney < 0)
            {
                Console.WriteLine("Sorry, not enough money");
                Console.WriteLine($"Change: {Math.Abs(totalMoney):f2}");
            }
            else if(totalMoney>=0)
            {
                Console.WriteLine($"Change: {Math.Abs(totalMoney):f2}");
            }
            
            
        }
    }
}
