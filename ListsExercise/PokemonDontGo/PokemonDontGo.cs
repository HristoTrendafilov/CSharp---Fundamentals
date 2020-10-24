using System;
using System.Linq;
using System.Collections.Generic;
namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstPokemon = pokemons[0];
                    sum += firstPokemon;
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > firstPokemon)
                        {
                            pokemons[i] -= firstPokemon;
                        }
                        else
                        {
                            pokemons[i] += firstPokemon;
                        }
                    }
                }
                else if (index > pokemons.Count-1)
                {
                    int lastPokemon = pokemons[pokemons.Count - 1];
                    sum += lastPokemon;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > lastPokemon)
                        {
                            pokemons[i] -= lastPokemon;
                        }
                        else
                        {
                            pokemons[i] += lastPokemon;
                        }
                    }
                }
                else
                {
                    int pokemon = pokemons[index];
                    sum += pokemon;
                    pokemons.RemoveAt(index);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] > pokemon)
                        {
                            pokemons[i] -= pokemon;
                        }
                        else
                        {
                            pokemons[i] += pokemon;
                        }
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
