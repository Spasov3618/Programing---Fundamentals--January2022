using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(("\\"))
                 .ToList();

            string[] value = input[input.Count - 1].Split('.');

            Console.WriteLine($"File name: {value[0]}");
            Console.WriteLine($"File extension: {value[1]}");

        }
    }
}
