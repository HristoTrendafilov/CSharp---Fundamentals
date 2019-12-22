using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            double size = 0;
            string model = string.Empty;
            

            for (int i = 0; i < counter; i++)
            {
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI *radius*2*height;

                if (volume > size)
                {
                    size = volume;
                    model = currentModel;
                }
               
            }
            Console.WriteLine(model);
        }
    }
}
