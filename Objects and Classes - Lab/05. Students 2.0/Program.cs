using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Student> students = new List<Student>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];
                Student replace = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
                if(replace == null)
                {
               Student student = new Student(firstName, lastName, age, city);
                students.Add(student);

                }
                else
                {
                replace.FirstName = firstName;
                    replace.LastName = lastName;
                    replace.Age = age;
                    replace.City = city;

                }
            }
            string filter = Console.ReadLine();
            foreach (Student item in students)
            {
                if (filter == item.City)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }
    }
}
