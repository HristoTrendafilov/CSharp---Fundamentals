using System;
using System.Linq;
using System.Collections.Generic;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if (StudentExists(students, firstName, lastName))
                {
                    Student student =Get
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;

                    students.Add(student);
                }

                line = Console.ReadLine();
            }
            string filteredCity = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.City == filteredCity).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

        }
        static bool StudentExists(List<Student> students,string firstName, string Lastname)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == Lastname)
                {
                    return true;
                }
            }
            return false;
        }
        static Student student(List<Student>students,string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName=firstName && student.LastName==lastName)
                {

                }
            }
        }
    }
}
