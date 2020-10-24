using System;
using System.Linq;
using System.Collections.Generic;
namespace CompanyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeId = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine().Split(" -> ").ToList();

                if (command[0] == "End")
                {
                    break;
                }

                var employee = command[0];
                var id = command[1];

                if (!employeeId.Keys.Contains(employee))
                {
                    employeeId.Add(employee, new List<string>());
                    employeeId[employee].Add(id);
                }
                if (!employeeId[employee].Contains(id))
                {
                    employeeId[employee].Add(id);
                }
            }
            foreach (var company in employeeId.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
