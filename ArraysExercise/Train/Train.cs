using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] peopleOnTheTrain = new int[count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int newPassagers = int.Parse(Console.ReadLine());
                sum += newPassagers;
                peopleOnTheTrain[i] = newPassagers;
                
            }
            for (int i = 0; i < peopleOnTheTrain.Length; i++)
            {
                Console.Write($"{peopleOnTheTrain[i]} ");
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
