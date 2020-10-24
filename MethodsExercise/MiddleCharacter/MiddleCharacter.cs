using System;

namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var strToCharArray = str.ToCharArray();

            PrintMiddleOfEven(str,strToCharArray);
            PrintMiddleOfOdd(str, strToCharArray);
            
        }
        static void PrintMiddleOfEven(string str, char[] strToCharArray)
        {
            if (strToCharArray.Length % 2 == 0)
            {
                int middle = strToCharArray.Length / 2;
                Console.Write(strToCharArray[middle - 1]);
                Console.Write(strToCharArray[middle]);
            }
        }
        static void PrintMiddleOfOdd(string str, char[] strToCharArray)
        {
            if (strToCharArray.Length % 2 == 1)
            {
                int middle = strToCharArray.Length / 2;
                Console.Write(strToCharArray[middle]);
            }
        }
    }
}
