using System;
using System.Collections.Generic;
using System.Linq;
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                string reversedWord = string.Empty;

                if (word == "end")
                {
                    break;
                }
                else
                {
                    for (int i = word.Length-1; i >=0; i--)
                    {
                        reversedWord += word[i];
                    }
                }
                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}
