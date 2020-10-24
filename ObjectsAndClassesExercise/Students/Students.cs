using System;
using System.Collections.Generic;
using System.Linq;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Students> totalStudents = new List<Students>();

            for (int i = 0; i < studentsCount; i++)
            {
                List<string> inputStudent = Console.ReadLine().Split().ToList();

                string firstName = inputStudent[0];
                string lastName = inputStudent[1];
                double grade = double.Parse(inputStudent[2]);

                var newStudent = new Students(firstName, lastName, grade);

                totalStudents.Add(newStudent);
            }
            List<Students> SortedList = totalStudents.OrderByDescending(o => o.Grade).ToList();

            foreach(var studen in SortedList)
            {
                Console.WriteLine(studen);
            }
        }
        class Students
        {
            public Students(string firstName,string lastname,double grade)
            {
                FirstName = firstName;
                LastName = lastname;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}
