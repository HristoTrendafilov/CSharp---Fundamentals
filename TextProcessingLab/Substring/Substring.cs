using System;
using System.Text;
namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removedWord = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            var result = word;

            while (result.Contains(removedWord))
            {
               result = result.Remove(result.IndexOf(removedWord), removedWord.Length);
            }
            Console.WriteLine(result);
        }
    }
}
