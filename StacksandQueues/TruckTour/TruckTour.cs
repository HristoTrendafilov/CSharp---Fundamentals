using System;
using System.Collections.Generic;
using System.Linq;
namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var petrolPumps = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var fuel = 0;

            for (int i = 0; i < petrolPumps; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }
            for (int i = 0; i < petrolPumps; i++)
            {
                
            }
        }
    }
}
