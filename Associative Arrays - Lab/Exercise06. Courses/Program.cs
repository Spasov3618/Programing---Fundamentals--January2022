using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте програма, която съхранява информацията за курсовете. Всеки курс има име и регистрирани студенти.
            //Ще получавате име на курс и име на студент, докато не получите командата "край".Проверете дали такъв курс вече съществува и ако не, добавете курса.Регистрирайте потребителя в курса. Когато получите командата "end", отпечатайте курсовете с техните имена и общия брой регистрирани потребители. За всеки конкурс отпечатайте регистрираните потребители.
            //Вход
            //• Докато не бъде получена командата "end", ще получавате вход във формат: "{courseName} : {studentName}".
            //• Данните за продукта винаги са разделени с " : ".
            //Изход
            //• Отпечатайте информацията за всеки курс в следния формат:
            //„{ courseName}: { registeredStudents}“
            //• Отпечатайте информацията за всеки ученик в следния формат:
            //"-- {studentName}"
            Dictionary<string,List<string>> dictionary = new Dictionary<string,List<string>>();
            string input;
            while ((input=Console.ReadLine())!= "end")
            {
                string[] info = input.Split(" : ");
                string nameCours = info[0];
                string students = info[1];
                if (!dictionary.ContainsKey(nameCours))
                {
                    dictionary.Add(nameCours,new List<string>());
                }
                dictionary[nameCours].Add(students);
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
