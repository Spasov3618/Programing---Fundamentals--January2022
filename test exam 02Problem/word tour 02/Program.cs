using System;
using System.Collections.Generic;
using System.Linq;

namespace World_Tour
{
    class Program
    {
        public static int firstSymvol { get; private set; }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Travel")
                {
                    Console.WriteLine($"Ready for world tour! Planned stops: {line}");
                    return;
                }
                string[] tokens = command.Split(":").ToArray();
                char simvol = tokens[0][0];
                if (simvol == 'A')
                {
                    int firstSimvol = int.Parse(tokens[1]);
                    string name = tokens[2];
                    if ((firstSymvol >= 0) && (firstSymvol < line.Length))
                    {
                       line = line.Insert(firstSimvol, name);
                    }
                    Console.WriteLine(line);
                }
                if (simvol == 'R')
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if ((startIndex >= 0) && (startIndex < endIndex) && (endIndex < line.Length))
                    {
                        line =line.Remove(startIndex, endIndex - startIndex);
                    }
                        Console.WriteLine(line);
                }
                if (simvol == 'S')
                {
                    string oldString = tokens[1];
                    string newString = tokens[2];
                   line =  line.Replace(oldString, newString);
                }
                    Console.WriteLine(line);
            }
        }
    }
}
