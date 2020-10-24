using System;
using System.Linq;
using System.Collections.Generic;
namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new Dictionary<string, Students>();

            while (true)
            {
                var command = Console.ReadLine().Split(" : ").ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                var course = command[0];
                var student = command[1];

                if (!classes.Keys.Contains(course))
                {
                    var newCourse = new Students();
                    newCourse.newStudents.Add(student);
                    classes.Add(course, newCourse);
                    classes[course].Counter++;
                    continue;
                }
                if (classes.Keys.Contains(course))
                {
                    classes[course].newStudents.Add(student);
                    classes[course].Counter++;
                }
            }

            foreach (var course in classes.OrderByDescending(x=>x.Value.Counter))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Counter}");

                foreach (var item in course.Value.newStudents.OrderBy(x=>x).ToList())
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
    class Students
    {
        public List<string> newStudents = new List<string>();

        public int Counter { get; set; }
    }
}
