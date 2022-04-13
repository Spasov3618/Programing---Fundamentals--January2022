using System;
using System.Collections.Generic;
using System.Linq;

namespace A04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Add { number} – add the given number to the end of the list
            //•	Insert { number}{ index} – insert the number at the given index
            //•	Remove { index} – remove the number at the given index
            //•	Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //•	Shift right { count} – last number becomes first. To be repeated the specified number of times

            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split(' ');
                if (split[0] == "Add")
                {
                    input.Add(int.Parse(split[1]));
                }
                else if (split[0] == "Insert")
                {
                    int number = int.Parse(split[1]);
                    int index = int.Parse(split[2]);
                    if (index<0 || index>=input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {

                    input.Insert(index, number);
                    }
                }
                else if (split[0] == "Remove")
                {
                    int index = int.Parse(split[1]);    
                    if (index<0 || index >= input.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {

                    input.RemoveAt(int.Parse(split[1]));
                    }
                }
                else if (split[0]== "Shift")
                {
                    int count = int.Parse(split[2]);
                    if (split[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                       int first = input[0];
                            input.RemoveAt(0);
                            input.Add(first);
                        }

                    }
                    else if(split[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int last = input[input.Count - 1];
                            input.Insert(0, last);
                            input.RemoveAt(input.Count - 1);
                        }
                    }
                    
                    
                }
            }
            Console.WriteLine(String.Join(" ",input));
        }
    }
}
