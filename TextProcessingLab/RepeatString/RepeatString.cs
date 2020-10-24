using System;
using System.Text;
namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            var repeated = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    repeated.Append(words[i]);
                }
            }
            Console.WriteLine(repeated);
        }
    }
}
