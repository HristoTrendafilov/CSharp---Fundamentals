using System;
using System.Linq;
namespace BombtheBasement
{
    class BombtheBasement
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new int[dimensions[0], dimensions[1]];

            var bombPerimeters= Console.ReadLine().Split().Select(int.Parse).ToArray();
            var row = bombPerimeters[0];
            var col = bombPerimeters[1];
            var radius = bombPerimeters[3];


        }
    }
}
