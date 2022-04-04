using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_03
{
    internal class Program
    {
        class Animals
        {public Animals(string name,int food,string area)
            {
                Name = name;
                Food = food;
                Area = area;
            }
           public string Name { get; set; }
            public int Food { get; set; }
            public string Area { get; set; }
        }
        static void Main(string[] args)
        {
          Dictionary<string, int> area = new Dictionary<string,int>();    
             


          List<Animals> zoo = new List<Animals>();
            
            string input;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] command = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Add")
                {
                    string[] arg = command[1].Split("-",StringSplitOptions.RemoveEmptyEntries);
                    string name = arg[0];
                    int food = int.Parse(arg[1]);
                    string areas = arg[2];   
                    Animals newAnimal = new Animals(name,food,areas);
                    Animals search = zoo.FirstOrDefault(a => a.Name == name);
                    if (!zoo.Contains(search))
                    {
                        zoo.Add(newAnimal);
                       
                    }
                    else
                    {
                        search.Food+=food;
                          
                    }
                }
                else if (command[0] == "Feed")
                {
                    string[] arg = command[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                    string name = arg[0];
                    int food = int.Parse(arg[1]);
                    Animals search = zoo.FirstOrDefault(a => a.Name == name);
                    if (zoo.Contains(search))
                    {
                        search.Food-=food;
                        
                          
                    }
                    else
                    {
                        continue;
                    }
                    if (search.Food <= 0)
                    {
                        zoo.Remove(search);
                        
                        Console.WriteLine($"{name} was successfully fed");
                    }
                }

            }
            Console.WriteLine("Animals:");
            foreach (var item in zoo)
            {
                Console.WriteLine($" {item.Name} -> {item.Food}g");
            }
           
            Console.WriteLine("Areas with hungry animals:");
           string[] areass = zoo.Select(x => x.Area).ToArray();
            List<string> newAreas = new List<string> ();
            for (int j = 0; j < areass.Length; j++)
            {
                string newArea = areass[j];
                if (!newAreas.Contains(newArea))
                {
                    newAreas.Add(newArea);
                }
            }
            for (int i = 0; i < newAreas.Count; i++)
            {

            int count = 0;
                foreach (var item in zoo)
                {
                    if (item.Area == newAreas[i])
                    {
                        count++;
                    }
                }
            Console.WriteLine($"{newAreas[i]}: {count}");
            }
           

            
        }
    }
}
