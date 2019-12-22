using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int char1 = int.Parse(Console.ReadLine());
            int char2 = int.Parse(Console.ReadLine());

            while (char1 <= char2)
            {
                Console.Write($"{(char)char1} ");
                char1++;
            }
        }
    }
}
