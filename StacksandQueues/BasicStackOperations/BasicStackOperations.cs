using System;
using System.Collections.Generic;
using System.Linq;
namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split();
            var elements = Console.ReadLine().Split();

            var numberOfElements = int.Parse(commands[0]);
            var popElements = int.Parse(commands[1]);
            var numberToLookFor = int.Parse(commands[2]);

            var smallestElement = 0;

            var stack = new Stack<int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                stack.Push(int.Parse(elements[i]));
            }
            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                for (int i = 0; i < stack.Count; i++)
                {
                    var currentNumber = stack.Pop();
                    if (smallestElement == 0)
                    {
                        smallestElement = currentNumber;
                    }
                    if (currentNumber < smallestElement)
                    {
                        smallestElement = currentNumber;
                    }
                }
                Console.WriteLine(smallestElement);
            }
        }
    }
}
