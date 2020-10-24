using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int wrongNumber = 0;
            bool correctNumber = false;

            while (command != "END")
            {
                var commandToArray = command.ToCharArray();

                var commandCopy = command.ToCharArray();
                Array.Reverse(commandCopy);

                for (int i = 0; i < commandToArray.Length; i++)
                {
                    if (commandToArray[i] == commandCopy[i])
                    {
                        correctNumber = true;
                    }
                    else
                    {
                        wrongNumber++;
                    }
                }
                if (wrongNumber >= 1)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
                wrongNumber = 0;

                command = Console.ReadLine();

            }
            
        }

    }
}
