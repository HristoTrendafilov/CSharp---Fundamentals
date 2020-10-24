using System;
using System.Collections.Generic;
using System.Linq;
namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            var queue = new Queue<string>();

            for (int i = 0; i < songs.Length; i++)
            {
                queue.Enqueue(songs[i]);
            }

            while (queue.Count>0)
            {
                var command = Console.ReadLine();
                if (command.StartsWith("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    var currentSong = command.Replace("Add ",string.Empty);
                    if (queue.Contains(currentSong))
                    {
                        Console.WriteLine($"{currentSong} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(currentSong);
                    }
                }
                else if (command.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
