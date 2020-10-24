using System;
using System.Linq;
namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var matrix = new int[counter, counter];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = command[col];
                }
            }
            var primary = 0;
            for (int rows = 0; rows < counter; rows++)
            {
                primary += matrix[rows,rows];
            }
            var secondary = 0;
            var secondaryCounter = 0;
            for (int rows = counter-1; rows >= 0; rows--)
            {
                secondary += matrix[secondaryCounter,rows];
                secondaryCounter++;
            }
            var diff = Math.Abs(primary - secondary);
            Console.WriteLine(diff);
        } 
    }
}
