using System;
using System.Linq;
namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();
            string[] str2 = Console.ReadLine().Split();

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str2[i] == str1[j])
                    {
                        Console.Write($"{str2[i]} ");
                    }
                }
            }

        }
    }
}
