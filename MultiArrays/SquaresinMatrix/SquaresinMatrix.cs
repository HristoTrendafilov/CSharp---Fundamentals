using System;
using System.Linq;
namespace SquaresinMatrix
{
    class SquaresinMatrix
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[rowsAndCols[0], rowsAndCols[1]];
            var success = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var characters = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = characters[col];
                }
            }
            for (int rows = 0; rows < matrix.GetLength(0)-1; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    if(matrix[rows,col] == matrix[rows+1,col] && matrix[rows,col+1] == matrix[rows + 1, col + 1])
                    {
                        success ++;
                    }
                }
            }
            Console.WriteLine(success);
        }
    }
}
