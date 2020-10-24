using System;
using System.Linq;
using System.Collections.Generic;
namespace BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNumber = bombNumbers[0];
            int bombPower = bombNumbers[1];
            bool detotantion = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    detotantion = true;
                    for (int j = 0; j < bombPower; j++)
                    {
                        if (i == 0)
                        {
                            break;
                        }

                        numbers.RemoveAt(i - 1);
                        i--;
                    }
                    for (int l = 0; l < bombPower; l++)
                    {
                        int lastCount = numbers.Count - 1;

                        if (i ==lastCount)
                        {
                            break;
                        }
                        numbers.RemoveAt(i + 1);
                    }
                }
                if (detotantion)
                {
                    numbers.RemoveAt(i);
                }
                detotantion = false;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
