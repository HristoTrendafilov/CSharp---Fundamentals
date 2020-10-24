using System;

namespace CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string char1 = Console.ReadLine();
            string char2 = Console.ReadLine();

            char input1 = char1[0];
            char input2 = char2[0];

            for (int i = input1+1; i <= input2-1; i++)
            {
                Console.Write((char)i + " ");
            }
            for (int i = input2+1;i<=input1-1 ; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
