using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^[^a]+[{}|#]*$");
            var encrypted = Console.ReadLine();
            if (regex.IsMatch(encrypted))
            {
                var decrypted = string.Empty;

                foreach (var character in encrypted)
                {
                    decrypted += (char)(character - 3);
                }
                var substrings = Console.ReadLine().Split();
                var word1 = substrings[0];
                var word2 = substrings[1];

                while (decrypted.Contains(word1))
                {
                    decrypted= decrypted.Replace(word1, word2);
                }
                Console.WriteLine(decrypted);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
