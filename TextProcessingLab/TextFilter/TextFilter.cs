using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string modifier = new string('*', bannedWords[i].Length);

                text = text.Replace(bannedWords[i], modifier);
            }
            Console.WriteLine(text);
        }
    }
}
