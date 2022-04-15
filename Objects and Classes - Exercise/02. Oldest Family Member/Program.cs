using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.Oldest_Family_Member
{
    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

public class Family
    {
        public List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.family.OrderByDescending(p => p.age).First();
        }
    }
class Program
{
    static void Main(string[] args)
    {
       
       

        Family family = new Family();
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            family.AddMember(new Person(name, age));
        }

        Person oldestMember = family.GetOldestMember();
        Console.WriteLine("{0} {1}", oldestMember.name, oldestMember.age);
    }
}
}