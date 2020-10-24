using System;
using System.Collections.Generic;
using System.Linq;
namespace MaximumandMinimumElement
{
    class MaximumMinimumElement
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var smallestNumber = int.MaxValue;
            var biggestNumber = int.MinValue;

            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    var element = int.Parse(command[1]);
                    stack.Push(element);

                    if (element < smallestNumber)
                    {
                        smallestNumber = element;
                    }
                    if (element > biggestNumber)
                    {
                        biggestNumber = element;
                    }
                }
                else if (command[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        var currentNumber = stack.Pop();

                        if (currentNumber == biggestNumber)
                        {
                            biggestNumber = int.MinValue;
                        }
                        if (currentNumber == smallestNumber)
                        {
                            smallestNumber = int.MaxValue;
                        }
                    }
                }
                else if (command[0] == "3")
                {
                    Console.WriteLine(biggestNumber);
                }
                else if (command[0] == "4")
                {
                    Console.WriteLine(smallestNumber);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
