using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var userCar = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                if (command[0] == "register")
                {
                    var user = command[1];
                    var carNumber = command[2];

                    if (!userCar.Keys.Contains(user))
                    {
                        userCar.Add(user, carNumber);
                        Console.WriteLine($"{user} registered {carNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    var user = command[1];

                    if (!userCar.Keys.Contains(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        userCar.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }
            foreach (var car in userCar)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
