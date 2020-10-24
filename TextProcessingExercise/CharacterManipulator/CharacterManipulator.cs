using System;

namespace CharacterManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var sum = 0;

            var result = Multipli(strings, sum);

            Console.WriteLine(result);
        }
        static int Multipli(string[] strings,int sum)
        {
           var str1 = strings[0];
           var str2 = strings[1];

           for (int i = 0; i < Math.Max(str1.Length,str2.Length); i++)
           {

                if (i >= str2.Length)
                {
                    sum += str1[i];
                }
                else if (i >= str1.Length)
                {
                    sum += str2[i];
                }
                else
                {
                    sum += str1[i] * str2[i];
                }
           }
            
            return sum;
        }
    }
}
