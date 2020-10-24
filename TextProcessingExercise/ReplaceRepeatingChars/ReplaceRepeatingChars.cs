using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string valid = string.Empty;
            valid += words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (valid[valid.Length-1]!=words[i])
                {
                    valid += words[i];
                }
            }
            Console.WriteLine(valid);
        }
    }
}
