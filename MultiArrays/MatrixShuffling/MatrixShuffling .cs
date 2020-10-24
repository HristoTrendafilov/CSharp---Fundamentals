using System;
using System.Linq;
namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[dimensions[0],dimensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var command = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = command[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();


                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] != "swap" || command.Length>5 || int.Parse(command[1])>matrix.GetLength(0)||
                    int.Parse(command[2])>matrix.GetLength(1) || int.Parse(command[3])>matrix.GetLength(0) || int.Parse(command[4])>matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (command[0] == "swap")
                {
                    var firstRow = int.Parse(command[1]);
                    var secondRow = int.Parse(command[3]);
                    var firstCol = int.Parse(command[2]);
                    var secondCol = int.Parse(command[4]);
                    var firstNumber = matrix[firstRow, firstCol];
                    var secondNumber = matrix[secondRow, secondCol];
                    matrix[firstRow, firstCol] = secondNumber;
                    matrix[secondRow, secondCol] = firstNumber;

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
    }
}
