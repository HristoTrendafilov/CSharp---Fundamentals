using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            double totalSpent = 0;

            while (command!="Game Time")
            {
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                if(command== "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 39.99;
                    }
                    totalSpent += 39.99;
                    balance -= 39.99;
                    Console.WriteLine("Bought OutFall 4");
                }
                else if(command== "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 15.99;
                    }
                    totalSpent += 15.99;
                    balance -= 15.99;
                    Console.WriteLine("CS: OG");
                }
                else if (command == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 19.99;
                        
                    }
                    totalSpent += 19.99;
                    balance -= 19.99;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else if (command == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 59.99;
                    }
                    totalSpent += 59.99;
                    balance -= 59.99;
                    Console.WriteLine("Bought Honored 2");
                }
                else if (command == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 29.99;
                    }
                    totalSpent += 29.99;
                    balance -= 29.99;
                    Console.WriteLine("Bought RoverWatch");
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        balance += 39.99;
                    }
                    totalSpent += 39.99;
                    balance -= 39.99;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
                command = Console.ReadLine();
            }
            if (balance >= 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${balance}");
            }
            

        }
    }
}
