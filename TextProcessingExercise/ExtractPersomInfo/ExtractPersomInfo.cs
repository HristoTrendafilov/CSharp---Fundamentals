using System;

namespace ExtractPersomInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var name = string.Empty;
                var age = string.Empty;

                var text = Console.ReadLine();

                var endName = text.IndexOf("|") - text.IndexOf("@")-1;
                name = text.Substring(text.IndexOf('@')+1, endName);

                var endAge = text.IndexOf("*") - text.IndexOf("#") - 1;
                age = text.Substring(text.IndexOf("#")+1, endAge);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
