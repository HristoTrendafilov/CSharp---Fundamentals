using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            ReturnString(words, repeat);
        }
        static void ReturnString (string words,int repeat)
        {
            string result = string.Empty;

            for (int i = 1; i <= repeat; i++)
            {
                result += words;
            }
            Console.WriteLine(result);
        }
    }
}
