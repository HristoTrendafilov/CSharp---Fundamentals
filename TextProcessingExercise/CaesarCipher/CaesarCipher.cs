using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var messege = Console.ReadLine();
            var encryptedMessege = string.Empty;

            foreach (var character in messege)
            {
                encryptedMessege += Convert.ToChar(character + 3);
            }
            Console.WriteLine(encryptedMessege);
        }
    }
}
