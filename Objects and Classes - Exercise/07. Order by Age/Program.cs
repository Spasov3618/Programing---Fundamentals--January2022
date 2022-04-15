using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }    
        public string  Id { get; set; } 
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Person> list = new List <Person> ();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = arg[0];
                string id = arg[1];
                int age = int.Parse(arg[2]);
                Person searchId = list.FirstOrDefault (x => x.Id == id);
                if (searchId != null)
                {
                    searchId.Name = name;
                    searchId.Age = age;
                    continue;
                }
                Person newPerson = new Person (name, id, age);
                list.Add (newPerson);
            } 
            List<Person> newList = list.OrderBy (x => x.Age).ToList ();
            foreach (Person  item in newList)
            {
                Console.WriteLine(item);
            }
        
        
        }
    }
}
