using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students.Where(kvp => kvp.Value.Average() >= 4.50m))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}
