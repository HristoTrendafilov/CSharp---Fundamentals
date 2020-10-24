using System;
using System.Linq;
namespace VowelsCount
{
    class Program

    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int vowelsCount = 0;
            var chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i]=='e' || chars[i] == 'i'|| chars[i] == 'o'|| chars[i] == 'u')
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
        

    }
}
