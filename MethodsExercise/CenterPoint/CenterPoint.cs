    using System;

    namespace CenterPoint
    {
        class Program
        {
            static void Main(string[] args)
            {
                int x1 = int.Parse(Console.ReadLine());
                int y1 = int.Parse(Console.ReadLine());
                int x2 = int.Parse(Console.ReadLine());
                int y2 = int.Parse(Console.ReadLine());

                ReturnClosestCoordinates(x1, y1, x2, y2);
            }
            static void ReturnClosestCoordinates(int x1,int y1,int x2,int y2)
            {
                int x1y1Count = 0;
                int x2y2Count = 0;
                int x1Abs = Math.Abs(x1);
                int x2Abs = Math.Abs(x2);
                int y1Abs = Math.Abs(y1);
                int y2Abs = Math.Abs(y2);

                for (int i = 0; i < x1Abs; i++)
                {
                    x1y1Count++;
                }
                for (int i = 0; i < y1Abs; i++)
                {
                    x1y1Count++;
                }
                for (int i = 0; i < x2Abs; i++)
                {
                    x2y2Count++;
                }
                for (int i = 0; i < y2Abs; i++)
                {
                    x2y2Count++;
                }
                if (x1y1Count < x2y2Count)
                {
                    Console.WriteLine($"({string.Join(", ",x1,y1)})");
                }
                else if (x2y2Count < x1y1Count)
                {
                    Console.WriteLine($"({string.Join(", ", x2, y2)})");
                }
                if (x1y1Count == x2y2Count)
                {
                    Console.WriteLine($"({string.Join(", ", x1, y1)})");
                }
            }
        }
    }
