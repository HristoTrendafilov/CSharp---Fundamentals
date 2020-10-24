using System;
using System.Linq;
using System.Collections.Generic;
namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resource.Keys.Contains(command))
                {
                    resource.Add(command, quantity);
                }
                else
                {
                    resource[command] += quantity;
                }
            }
            foreach (var resourc in resource)
            {
                string resourceName = resourc.Key;
                int resourceCount = resourc.Value;

                Console.WriteLine($"{resourceName} -> {resourceCount}");
            }
        }
    }
}
