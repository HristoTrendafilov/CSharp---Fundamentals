using System;
using System.Collections.Generic;
using System.Linq;
namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string currentText = text[i];
                char firstLetter = currentText[0];
                char lastLetter = currentText[currentText.Length - 1];
                double numbers = double.Parse(currentText.Substring(1, currentText.Length-2));

                if (char.IsUpper(firstLetter))
                {
                    numbers /= (int)firstLetter % 32;
                }
                else if (char.IsLower(firstLetter))
                {
                    numbers *= (int)firstLetter % 32;
                }
                if (char.IsUpper(lastLetter))
                {
                    numbers -= (int)lastLetter % 32;
                }
                else if (char.IsLower(lastLetter))
                {
                    numbers +=(int)lastLetter % 32;
                }
                sum += numbers;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
