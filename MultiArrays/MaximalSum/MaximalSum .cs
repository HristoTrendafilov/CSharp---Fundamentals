using System;
using System.Linq;
using System.Collections.Generic;
namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new long[rowsAndCols[0], rowsAndCols[1]];
            long totalSum = 0;
            var combination = new List<long>();

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var characters = Console.ReadLine().Split().Select(long.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = characters[col];
                }
            }
            for (int rows = 0; rows < matrix.GetLength(0)-2; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    if (matrix[rows, col] + matrix[rows, col + 1] + matrix[rows,col+2]+
                        matrix[rows+1,col]+matrix[rows+1,col+1]+matrix[rows+1,col+2]+
                        matrix[rows+2,col]+matrix[rows+2,col+1]+matrix[rows+2,col+2]
                        > totalSum)
                    {
                        combination.Clear();
                        totalSum = matrix[rows, col] + matrix[rows, col + 1] + matrix[rows, col + 2] +
                        matrix[rows + 1, col] + matrix[rows + 1, col + 1] + matrix[rows + 1, col + 2] +
                        matrix[rows + 2, col] + matrix[rows + 2, col + 1] + matrix[rows + 2, col + 2];

                        combination.Add(matrix[rows, col]);
                        combination.Add(matrix[rows, col + 1]);
                        combination.Add(matrix[rows, col + 2]);
                        combination.Add(matrix[rows+1, col]);
                        combination.Add(matrix[rows+1, col+1]);
                        combination.Add(matrix[rows+1, col+2]);
                        combination.Add(matrix[rows+2, col]);
                        combination.Add(matrix[rows+2, col+1]);
                        combination.Add(matrix[rows+2, col+2]);
                    }
                }
            }
            Console.WriteLine($"Sum = {totalSum}");

            for (int i = 0; i < combination.Count; i++)
            {
                if(i==3 || i == 6)
                {
                    Console.WriteLine();
                }
                Console.Write($"{combination[i]} ");
            }

        }
    }
}
