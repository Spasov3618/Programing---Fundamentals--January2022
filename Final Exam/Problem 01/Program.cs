using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string[] arg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arg[0];
                if (action == "Abjuration")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (action == "Necromancy")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (action == "Illusion")
                {
                    int index = int.Parse(arg[1]);
                    string symbol = arg[2];
                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, symbol);
                        input = input.Remove(index + 1,1);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (action == "Divination")
                {
                    string firstSubstring = arg[1];
                    string secondSubstring = arg[2];
                    if (input.Contains(firstSubstring))
                    {
                        input = input.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(input);
                    }
                }
                else if (action == "Alteration")
                {
                    string substring = arg[1];
                    if (input.Contains(substring))
                    {
                        int index = input.IndexOf(substring);
                        input = input.Remove(index, substring.Length);
                        Console.WriteLine(input);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
    }
}
