using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace OntheWaytoAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeAndItems = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine().Split("->");

                if(command[0]== "END")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    var store = command[1];
                    var item = command[2];

                    if (command[2].Contains(","))
                    {
                       var newItem = item.Split(",");

                        if (storeAndItems.ContainsKey(store))
                        {

                            for (int i = 0; i < newItem.Length; i++)
                            {
                                storeAndItems[store].Add(newItem[i]);
                            }
                            continue;
                        }
                        else
                        {
                            storeAndItems.Add(store, new List<string>());

                            for (int i = 0; i < newItem.Length; i++)
                            {
                                storeAndItems[store].Add(newItem[i]);
                            }
                            continue;
                        }
                    }
                    if (storeAndItems.ContainsKey(store))
                    {
                        storeAndItems[store].Add(item);
                    }
                    else
                    {
                        storeAndItems.Add(store, new List<string>());
                        storeAndItems[store].Add(item);
                    }
                }
                else if (command[0] == "Remove")
                {
                    var store = command[1];

                    if (storeAndItems.ContainsKey(store))
                    {
                        storeAndItems.Remove(store);
                    }
                }
            }
            Console.WriteLine("Stores list:");
            foreach (var store in storeAndItems.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
