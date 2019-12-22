using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int startingPokePower = pokePower;
            int distanceBetweenPokes = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedTargets = 0;
            

            while (pokePower>=distanceBetweenPokes )
            {
                pokePower -= distanceBetweenPokes;
                pokedTargets++;

                if (pokePower == startingPokePower / 2)
                {
                    if (pokePower >= exhaustionFactor)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
