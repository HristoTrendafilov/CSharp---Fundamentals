using System;

namespace ASCIIsimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch1 = Console.ReadLine();
            var ch2 = Console.ReadLine();

            var text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > ch1[0] && text[i] < ch2[0])
                {
                    sum += text[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
