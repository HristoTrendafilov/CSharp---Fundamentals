using System;

namespace DigitsLettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string isDigit = string.Empty;
            string isLetter = string.Empty;
            string isOther = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    isDigit += text[i];
                }
                else if (char.IsLetter(text[i]))
                {
                    isLetter += text[i];
                }
                else
                {
                    isOther += text[i];
                }
            }
            Console.WriteLine(isDigit);
            Console.WriteLine(isLetter);
            Console.WriteLine(isOther);
        }
    }
}
