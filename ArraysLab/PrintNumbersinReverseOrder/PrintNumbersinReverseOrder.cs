using System;

namespace PrintNumbersinReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }  
            for (int i = count-1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
           
        }
    }
}
