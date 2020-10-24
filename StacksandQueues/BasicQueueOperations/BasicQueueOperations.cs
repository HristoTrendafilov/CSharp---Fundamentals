using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split();
            var elements = Console.ReadLine().Split();

            var numberOfElements = int.Parse(commands[0]);
            var Dequeuelements = int.Parse(commands[1]);
            var numberToLookFor = int.Parse(commands[2]);

            var smallestElement = int.MaxValue;

            var queue = new Queue<int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                queue.Enqueue(int.Parse(elements[i]));
            }
            for (int i = 0; i < Dequeuelements; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(numberToLookFor) && queue.Count>0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    var currentNumber = queue.Dequeue();
                  
                    if (currentNumber < smallestElement)
                    {
                        smallestElement = currentNumber;
                    }
                }
                Console.WriteLine(smallestElement);
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
