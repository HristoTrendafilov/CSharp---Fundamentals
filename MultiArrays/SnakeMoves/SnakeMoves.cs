using System;
using System.Linq;
namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[dimensions[0], dimensions[1]];
            var snake = Console.ReadLine();
            var snakeLenght = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (snakeLenght == snake.Length)
                    {
                        snakeLenght = 0;
                    }
                    var @char = snake[snakeLenght].ToString();
                    matrix[row, col] = @char;
                    snakeLenght++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        Console.Write(matrix[row,col]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
