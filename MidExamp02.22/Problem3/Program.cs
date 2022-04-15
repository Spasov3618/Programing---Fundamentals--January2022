using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine().Split("&",StringSplitOptions.RemoveEmptyEntries).ToList();
            string going;
            while ((going=Console.ReadLine()) != "Done")
            {
                string[] input =going .Split(" | ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string comand = input[0];
                if (comand == "Add Book")
                {
                    string name = input[1];
                    if (library.Contains(name))
                    {
                        continue;

                    }
                    else if (!library.Contains(name))
                    {
                        library.Insert(0, name);
                    }
                }
                else if (comand == "Take Book")
                {
                    string name = input[1];
                    if (library.Contains(name))
                    {
                        library.RemoveAll(x => x == name);
                    }
                    else
                    {

                        continue;
                    }
                }
                else if (comand == "Swap Books")
                {
                    string name1 = input[1];
                    string name2 = input[2];
                    if (library.Contains(name1) && library.Contains(name2))
                    {
                        int book1Index =library.IndexOf(name1);
                        int book2Index = library.IndexOf(name2);
                        
                        library.Insert(book1Index, name2);
                        library.RemoveAt(book1Index + 1);
                        library.Insert(book2Index, name1);
                        library.RemoveAt(book2Index + 1);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (comand == "Insert Book")
                {
                    string name = input[1];
                    if (library.Contains(name))
                    {
                        continue;
                    }
                    else
                    {
                        library.Add(name);
                    }
                }
                else if (comand == "Check Book")
                {
                    int index = int.Parse(input[1]);
                    if (index>=0 && index<library.Count)
                    {
                        Console.WriteLine($"{library[index]}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", library));
        }
    }
}
