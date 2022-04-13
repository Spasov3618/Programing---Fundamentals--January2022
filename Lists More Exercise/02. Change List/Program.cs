using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
            //Your program may receive the following commands:
            //•	Delete { element} – delete all elements in the array, which are equal to the given element.
            //•	Insert { element} { position} – insert the element at the given position.
            //You should exit the program when you receive the "end" command.Print all numbers in the array separated by a single whitespace.
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split();
                if (token[0]== "Delete")
                {
                    int num = int.Parse(token[1]);  
                    input.RemoveAll(x => x == num);
                }
                else if (token[0] == "Insert")
                {
                    int num = int.Parse(token[1]);
                    int index = int.Parse(token[2]);    
                    input.Insert(index, num);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
