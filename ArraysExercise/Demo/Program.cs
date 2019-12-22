using System;
using System.Linq;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaSequences = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int sum = 0;
            
            while(command != "Clone them!")
            {
                string[] dnaSequence = Console.ReadLine().Split("!").ToArray();
                if(dnaSequence="Clone Them!")
                {

                }
                int[] dnaSequenceInt = Array.ConvertAll(dnaSequence, Int32.Parse);

                for (int i = 0; i < dnaSequenceInt.Length; i++)
                {
                    sum += dnaSequenceInt[i];
                    
                }
            }
            Console.WriteLine("pffff");
        }   
    }
}
