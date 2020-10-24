using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePlace = Console.ReadLine().Split(".");

            var name = filePlace[0].Split("\\");
            var lastWord = name[name.Length - 1];
            var extension = filePlace[1];

            Console.WriteLine($"File name: {lastWord}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
