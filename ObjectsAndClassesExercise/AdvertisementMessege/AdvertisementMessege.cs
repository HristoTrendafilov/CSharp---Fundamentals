using System;
using System.Collections.Generic;
using System.Linq;
namespace AdvertisementMessege
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int randomPhraseIndex = rnd.Next(0, 6);
                int randomEventIndex = rnd.Next(0, 6);
                int randomAuthorIndex = rnd.Next(0, 8);
                int randomCityIndex = rnd.Next(0, 5);
                Console.WriteLine($"{phrases[randomPhraseIndex]} {events[randomEventIndex]} {authors[randomAuthorIndex]} - {cities[randomCityIndex]}");
            }
        }
    }
}
