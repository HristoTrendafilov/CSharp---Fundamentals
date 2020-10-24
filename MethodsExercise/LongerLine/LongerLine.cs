using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            ReturnLongestLineOfCoordinates(x1, y1, x2, y2);
        }
        static void ReturnLongestLineOfCoordinates(int x1, int y1, int x2, int y2)
        {
            int longestLine = 0;
            int currentLine = 0;
            int x1y1 = 0;
            int x2y2 = 0;
            int x1y1top = 0;
            int x2y2top = 0;

            int x1Abs = Math.Abs(x1);
            int x2Abs = Math.Abs(x2);
            int y1Abs = Math.Abs(y1);
            int y2Abs = Math.Abs(y2);

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 0; j <= x1Abs; j++)
                {
                    currentLine++;
                    x1y1++;
                }
                for (int k = 0; k <= y1Abs; k++)
                {
                    currentLine++;
                    x1y1++;
                }
                for (int l = 0; l <= x2Abs; l++)
                {
                    currentLine++;
                    x2y2++;
                }
                for (int m = 0; m <= y2Abs; m++)
                {
                    currentLine++;
                    x2y2++;
                }
                if (currentLine > longestLine)
                {
                    x1y1top = x1y1;
                    x2y2top = x2y2;
                    longestLine = currentLine;
                }
                x1y1 = 0;
                x2y2 = 0;
                currentLine = 0;
                if (i < 2)
                {
                    x1 = int.Parse(Console.ReadLine());
                    y1 = int.Parse(Console.ReadLine());
                    x2 = int.Parse(Console.ReadLine());
                    y2 = int.Parse(Console.ReadLine());
                }
                
            }
            if (x1y1 > x2y2)
            {
                Console.Write($"({string.Join(", ", x1, y1)})");
                Console.Write($"({string.Join(", ", x2, y2)})");
            }
            else if(x2y2>x1y1)
            {
                Console.Write($"({string.Join(", ", x2, y2)})");
                Console.Write($"({string.Join(", ", x1, y1)})");
            }
            else 
            {
                Console.Write($"({string.Join(", ", x2, y2)})");
                Console.Write($"({string.Join(", ", x1, y1)})");
            }
        }
            
    }
}
