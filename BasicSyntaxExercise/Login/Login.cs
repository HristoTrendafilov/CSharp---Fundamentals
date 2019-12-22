using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string reversePassword = string.Empty;

            for (int n = userName.Length - 1; n >= 0; n--)
            {
                reversePassword += userName[n];
            }
            for (int i = 0; i < 3; i++)
            {
                string password = Console.ReadLine();
               
                
                if (password == reversePassword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                   return;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {userName} blocked!");
        }
    }
}
