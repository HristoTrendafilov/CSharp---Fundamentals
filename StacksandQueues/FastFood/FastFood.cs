using System;
using System.Collections.Generic;
using System.Linq;
namespace FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            var quantityOfFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var orderOfOrders = new Queue<int>();
            var biggestOrder = int.MinValue;

            for (int i = 0; i < orders.Length; i++)
            {
                orderOfOrders.Enqueue(orders[i]);

                if (orders[i] > biggestOrder)
                {
                    biggestOrder = orders[i];
                }
            }
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orderOfOrders.Count; i++)
            {
                var peekOrder = orderOfOrders.Peek();

                if (quantityOfFood >= peekOrder)
                {
                    var currentOrder = orderOfOrders.Dequeue();
                    quantityOfFood -= currentOrder;
                    i--;
                }
            }
            if (orderOfOrders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orderOfOrders)}");
            }
        }
    }
}
