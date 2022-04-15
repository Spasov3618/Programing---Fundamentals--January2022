using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise01._Company_Roster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определете клас Служител, който съдържа следната информация: име, заплата и отдел.
            //Вашата задача е да напишете програма, която взема N реда служители от конзолата, изчислява отдела с най - висока средна заплата и отпечатва за всеки служител в този отдел неговото име и заплата – сортирани по заплата в низходящ ред. Заплатата трябва да бъде закръглена до две цифри след десетичния разделител.
            List<Employee> list = new List<Employee>();
            List<string> departments = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                Employee newEmpoyee = new Employee(name, salary, department);
                list.Add(newEmpoyee);
                departments.Add(department);
            }
            departments = departments.Distinct().ToList();

            //find Department with Highest Average Salary
            string departmentHighestAve = "";
            double highestAveSalary = double.MinValue;

            foreach (string department in departments)
            {
                double aveSalary = list.Where(e => e.Department == department).Select(e => e.Salary).Average();
                if (aveSalary > highestAveSalary)
                {
                    departmentHighestAve = department;
                    highestAveSalary = aveSalary;
                }
            }

            //Printing results
            Console.WriteLine($"Highest Average Salary: {departmentHighestAve}");

            foreach (var employee in list.Where(e => e.Department == departmentHighestAve).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}
