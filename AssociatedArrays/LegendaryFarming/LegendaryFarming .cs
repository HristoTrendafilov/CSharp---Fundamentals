using System;
using System.Linq;
using System.Collections.Generic;
namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryLeapons = new Dictionary<string, int>();
            legendaryLeapons.Add("Shadowmourne", 0);
            legendaryLeapons.Add("Valanyr", 0);
            legendaryLeapons.Add("Dragonwrath", 0);

            var resources = new Dictionary<string, int>();
            resources.Add("fragments", 0);
            resources.Add("shards", 0);
            resources.Add("motes", 0);

            var junk = new Dictionary<string, int>();

            bool hasMaterials = false;

            while (true)
            {
                if (hasMaterials)
                {
                    break;
                }

                var input = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 1; i <= input.Length; i++)
                {
                    if (i % 2 == 1 && !resources.Keys.Contains(input[i]))
                    {
                        int quantity = int.Parse(input[i-1]);

                        if (input[i] == "shards")
                        {
                            resources.Add(input[i], quantity);
                            legendaryLeapons["Shadowmourne"] += quantity;

                            if (legendaryLeapons["Shadowmourne"] >= 250)
                            {
                                resources["shards"] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else if (input[i] == "fragments")
                        {
                            resources.Add(input[i], quantity);
                            legendaryLeapons["Valanyr"] += quantity;

                            if (legendaryLeapons["Valanyr"] >= 250)
                            {
                                resources["fragments"] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else if (input[i] == "motes")
                        {
                            resources.Add(input[i], quantity);
                            legendaryLeapons["Dragonwrath"] += quantity;

                            if (legendaryLeapons["Dragonwrath"] >= 250)
                            {
                                resources["motes"] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else
                        {
                            junk.Add(input[i], quantity);
                        }
                    }
                    else if (i % 2 == 1 && resources.Keys.Contains(input[i]))
                    {
                        int quantity = int.Parse(input[i - 1]);

                        if (input[i] == "shards")
                        {
                            resources[input[i]] += quantity;
                            legendaryLeapons["Shadowmourne"] += quantity;

                            if (legendaryLeapons["Shadowmourne"] >= 250)
                            {
                                resources["shards"] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else if (input[i] == "fragments")
                        {
                            resources[input[i]] += quantity;
                            legendaryLeapons["Valanyr"] += quantity;

                            if (legendaryLeapons["Valanyr"] >= 250)
                            {
                                resources["fragments"] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else if (input[i] == "motes")
                        {
                            resources[input[i]] += quantity;
                            legendaryLeapons["Dragonwrath"] += quantity;

                            if (legendaryLeapons["Dragonwrath"] >= 250)
                            {
                                resources["motes"] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                hasMaterials = true;
                                break;
                            }
                        }
                        else
                        {
                            junk[input[i]] += quantity;
                        }
                    }
                   
                }
            }
            var orderedResources = resources.OrderByDescending(x => x.Value);
            foreach (var product in orderedResources)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            var sortedJunk = junk.OrderBy(x => x.Key);
            foreach (var product in sortedJunk)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
        }
    }
}
