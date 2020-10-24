using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Messaging
{
    class Program
    {
        static int GetSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static int CorrectIndex(int index, int length)
        {
            while (index > length)
            {
                index -= length;
            }
            return index;
        }
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            foreach (var item in list)
            {
                int fullIndex = GetSum(item);
                int correctedIndex = CorrectIndex(fullIndex, text.Length);
                Console.Write(text[correctedIndex]);
                text = text.Remove(correctedIndex, 1);
            }
        }
    }
}
