using System;
using System.Collections.Generic;

namespace _04._Students
{
    class Student
    {
        public Student (string firstName, string lastName,int age,string city)
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
            //Дефинирайте клас, наречен Student, който ще съдържа следната информация за някои ученици:
            //•	първо име
            //•	фамилия
            //• възраст
            //•	роден град
            //Вход / Ограничения
            //Прочетете информация за някои ученици, докато не получите командата "end".След това ще получите име на град.
            //Изход
            //Отпечатайте учениците, които са от дадения град в следния формат: "{firstName} {lastName} is {age} years old."
            List<Student> students = new List<Student> ();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);  
                string city = input[3];
                Student student = new Student (firstName, lastName, age, city); 
                students.Add (student);
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
