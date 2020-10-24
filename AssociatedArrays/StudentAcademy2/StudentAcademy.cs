using System;
using System.Linq;
using System.Collections.Generic;
namespace StudentAcademy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            var studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < counter; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsAndGrades.Keys.Contains(name))
                {
                    studentsAndGrades[name].Add(grade);
                }
                else if (!studentsAndGrades.Keys.Contains(name))
                {
                    studentsAndGrades.Add(name, new List<double>());
                    studentsAndGrades[name].Add(grade);
                }
            }
            foreach (var student in studentsAndGrades.OrderByDescending(x=>x.Value.Average()))
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
            }
        }
    }
}
