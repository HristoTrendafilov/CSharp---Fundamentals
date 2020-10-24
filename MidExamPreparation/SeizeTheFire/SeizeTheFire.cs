using System;
using System.Linq;
using System.Collections.Generic;
namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fireCells = Console.ReadLine().Replace(" ", string.Empty).Split('#', '=').Where(x => !string.IsNullOrEmpty(x)).ToList();
            List<string> fireType = new List<string>();
            List<int> firePower = new List<int>();
            List<int> removedCells = new List<int>();

            for (int i = 0; i < fireCells.Count; i++)
            {
                if (i % 2 == 0)
                {
                    fireType.Add(fireCells[i]);
                }
                else if (i % 2 == 1)
                {
                    firePower.Add(int.Parse(fireCells[i]));
                }
            }
            int waterSupply = int.Parse(Console.ReadLine());

            double totalFire = 0;
            double totalEffort = 0;

            for(int i =0;i<fireType.Count;i++)
            {
                if (waterSupply <=0)
                {
                    break;
                }
                switch (fireType[i])
                {
                    case "High":
                        if (firePower[i] >= 81 && firePower[i] <= 125&& waterSupply>=firePower[i])
                        {
                            waterSupply -= firePower[i];
                            totalFire += firePower[i];
                            totalEffort += firePower[i] * 0.25;
                            removedCells.Add(firePower[i]);
                        }
                        break;
                    case "Medium":

                        if (firePower[i] >= 51 && firePower[i] <= 80&&waterSupply >= firePower[i])
                        {
                            waterSupply -= firePower[i];
                            totalFire += firePower[i];
                            totalEffort += firePower[i] * 0.25;
                            removedCells.Add(firePower[i]);
                        }
                        break;
                    case "Low":
                        if (firePower[i] >= 1 && firePower[i] <= 50 && waterSupply >= firePower[i])
                        {
                            waterSupply -= firePower[i];
                            totalFire += firePower[i];
                            totalEffort += firePower[i] * 0.25;
                            removedCells.Add(firePower[i]);
                        }
                        break;
                }
            
            }
            Console.WriteLine("Cells:");
            if (removedCells.Count > 0)
            {
                for (int i = 0; i < removedCells.Count; i++)
                {
                    Console.WriteLine($" - {removedCells[i]}");
                }
            }
            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
