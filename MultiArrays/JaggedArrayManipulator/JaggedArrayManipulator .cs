using System;
using System.Linq;
namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var numbers = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                numbers[i] = new int[command.Length];
                for (int j = 0; j < command.Length; j++)
                {
                    numbers[i][j] = command[j];
                }
            }
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i].Length == numbers[i + 1].Length)
                {
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        numbers[i][j] *= 2;
                        numbers[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        numbers[i][j] /= 2;
                    }
                    for (int k = 0; k < numbers[i+1].Length; k++)
                    {
                        numbers[i+1][k] /= 2;
                    }
                }
            }
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    var row = int.Parse(command[1]);
                    var col = int.Parse(command[2]);
                    var value = int.Parse(command[3]);
                    if (row < 0 || col<0)
                    {
                        continue;
                    }

                    if(row<numbers.Length && col<numbers[row].Length)
                    {
                        numbers[row][col] += value;
                    }
                }
                else if(command[0]== "Subtract")
                {
                    var row = int.Parse(command[1]);
                    var col = int.Parse(command[2]);
                    var value = int.Parse(command[3]);
                    if (row < 0 || col<0)
                    {
                        continue;
                    }

                    if (row < numbers.Length && col < numbers[row].Length)
                    {
                        numbers[row][col] -= value;
                    }

                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
