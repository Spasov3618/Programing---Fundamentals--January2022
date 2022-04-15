using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                int counter = 0;
                string output = "";
                for (int j = 0; j < input.Length; j++)
                {
                    string newinput = input.ToLower();
                    if (newinput[j] == 's' || newinput[j]== 't' || newinput[j] == 'a' || newinput[j] == 'r')
                    {
                        counter++;    
                    }
                }
                for (int m = 0; m < input.Length; m++)
                {

                     output += (char)(input[m] - counter);
                }
                string pattern = @"@(?<name>[A-z]+)[^@:!\->]*:(?<population>[\d]+)[^@:!\->]*!(?<attac>[A-Z])![^@:!\->]*->(?<army>[\d]+)";
               Match math = Regex.Match(output, pattern);
                string name = math.Groups["name"].Value;
                string attac = math.Groups["attac"].Value;
                if (attac == "A")
                {
                    attacked.Add(name);
                }
                else if(attac == "D")
                {
                    destroyed.Add(name);
                }
            }
             attacked.Sort();
            destroyed.Sort();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            if (attacked.Count>0)
            {
            foreach (var item in attacked)
            {
                Console.WriteLine($"-> {item}");
            }

            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count>0)
            {
                foreach (var item in destroyed)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
