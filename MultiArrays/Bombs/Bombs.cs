using System;
using System.Linq;
namespace Bombs
{
    class Bombs
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = numbers[j];
                }
            }
            var coordinates = Console.ReadLine().Split();

            for (int i = 0; i < coordinates.Length; i++)
            {
                var coordinatesParts = coordinates[i].Split(',');
                var row = int.Parse(coordinatesParts[0]);
                var col = int.Parse(coordinatesParts[1]);

                if (row < matrix.GetLength(0) && col < matrix.GetLength(0))
                {
                    var power = matrix[row, col];
                    if (power <= 0)
                    {
                        continue;
                    }
                    matrix[row, col] = 0;

                    if (row == 0 && col == 0)
                    {
                        if(matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= power;
                        }
                        if(matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= power;
                        }
                        if(matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= power;
                        }
                    }
                    else if (row == matrix.GetLength(1)-1 && col == 0)
                    {
                        if(matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= power;
                        }
                        if (matrix[row - 1, col] >0)
                        {
                            matrix[row - 1, col] -= power;
                        }
                        if (matrix[row - 1, col + 1] >0)
                        {
                            matrix[row - 1, col + 1] -= power;
                        }
                    }
                    else if (row > 0 && row < matrix.GetLength(0) && col == 0)
                    {
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= power;
                        }
                        if (matrix[row - 1, col] > 0)
                        {
                            matrix[row - 1, col] -= power;
                        }
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= power;
                        }
                        if (matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= power;
                        }
                        if (matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= power;
                        }
                    }
                    else if (row == 0 && col == matrix.GetLength(1)-1)
                    {
                        matrix[row, col - 1] -= power;
                        matrix[row + 1, col] -= power;
                        matrix[row + 1, col - 1] -= power;
                    }
                    else if (row == matrix.GetLength(0)-1 && col == matrix.GetLength(1)-1)
                    {
                        matrix[row, col - 1] -= power;
                        matrix[row - 1, col] -= power;
                        matrix[row - 1, col - 1] -= power;
                    }
                    else if (row > 0 && row < matrix.GetLength(0) && col == matrix.GetLength(1)-1)
                    {
                        matrix[row - 1, col] -= power;
                        matrix[row - 1, col - 1] -= power;
                        matrix[row, col - 1] -= power;
                        matrix[row + 1, col] -= power;
                        matrix[row + 1, col - 1] -= power;
                    }
                    else if (row == 0 && col > 0 && col < matrix.GetLength(1))
                    {
                        matrix[row, col + 1] -= power;
                        matrix[row, col - 1] -= power;
                        matrix[row + 1, col] -= power;
                        matrix[row + 1, col - 1] -= power;
                        matrix[row + 1, col + 1] -= power;
                    }
                    else if (row == matrix.GetLength(1)-1 && col > 0 && col < matrix.GetLength(1))
                    {
                        matrix[row, col + 1] -= power;
                        matrix[row, col - 1] -= power;
                        matrix[row - 1, col] -= power;
                        matrix[row - 1, col + 1] -= power;
                        matrix[row - 1, col - 1] -= power;
                    }
                    else if (row > 0 && row < matrix.GetLength(0) && col > 0 && col < matrix.GetLength(1))
                    {
                        if(matrix[row - 1, col] > 0)
                        {
                           matrix[row - 1, col] -= power;
                        }
                        if(matrix[row - 1, col - 1] > 0)
                        {
                           matrix[row - 1, col - 1] -= power;
                        }
                        if(matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= power;
                        }
                        if(matrix[row, col + 1] > 0)
                        {
                            matrix[row, col + 1] -= power;
                        }
                        if (matrix[row, col - 1] > 0)
                        {
                            matrix[row, col - 1] -= power;
                        }
                        if(matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= power;
                        }
                        if (matrix[row + 1, col - 1] > 0)
                        {
                            matrix[row + 1, col - 1] -= power;
                        }
                        if(matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= power;
                        }
                       
                       
                    }
                }
            }
            var aliveCells = 0;
            var maxSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        maxSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {maxSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
