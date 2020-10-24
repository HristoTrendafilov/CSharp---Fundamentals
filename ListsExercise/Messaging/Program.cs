using System;
using System.Linq;
using System.Collections.Generic;
namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            string numberIndexLetterIndex = string.Empty;

            List<char> textToList = new List<char>();
            textToList.AddRange(text);

            for (int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                int[] numbersIndex = num.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
                int sum = numbersIndex.Sum();

                int counter = -1;

                for (int j = 0; j < textToList.Count; j++)
                {
                    if (j == textToList.Count - 1)
                    {
                        j = -1;
                    }
                    counter++;
                    if (counter == sum)
                    {
                        numberIndexLetterIndex += textToList[j];
                        textToList.RemoveAt(j);
                        break;
                    }
                }

                num = 0;
                counter = 0;
            }
            Console.WriteLine(numberIndexLetterIndex);
        }
    }
}
