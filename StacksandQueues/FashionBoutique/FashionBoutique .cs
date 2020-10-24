using System;
using System.Collections.Generic;
using System.Linq;
namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var capacityOfRack = int.Parse(Console.ReadLine());
            var totalRacks = 1;
            int currentCapacity = 0;

            var stack = new Stack<int>();

            for (int i = 0; i < clothes.Length; i++)
            {
                stack.Push(clothes[i]);
            }

            while (stack.Count>0)
            {
                var currentCloth = stack.Pop();
                currentCapacity += currentCloth;

                if (currentCapacity > capacityOfRack)
                {
                    totalRacks++;
                    currentCapacity = currentCloth;
                }
                if (currentCapacity == capacityOfRack && stack.Count>0)
                {
                    totalRacks++;
                    currentCapacity = 0;
                }
            }
            Console.WriteLine(totalRacks);
        }
    }
}
