using System;

namespace CalculatingRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }
        static double  GetRectangleArea(double width,double height)
        {
            return width * height;
        }
    }
}
