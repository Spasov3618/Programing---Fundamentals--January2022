using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstname = input[0];    
                string lastname = input[1];
                double grade = double.Parse(input[2]);
                Student students = new Student(firstname, lastname, grade);
                list.Add(students);
            }
            List<Student> filtered = list.OrderBy(x => x.Grade).ToList();
            filtered.Reverse();
           foreach(Student student in filtered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
