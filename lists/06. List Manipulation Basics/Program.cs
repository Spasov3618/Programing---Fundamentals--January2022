using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] token = comand.Split(" ");
                if (token[0] == "Add")
                {
                    int num = int.Parse(token[1]);
                    input.Add(num);
                }
                else if(token[0] == "Remove")
                {
                    input.Remove(int.Parse(token[1]));
                }
                else if(token[0] =="RemoveAt")
                {
                    input.RemoveAt(int.Parse(token[1]));

                }
                else if (token[0]== "Insert")
                {
                    int num = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    input.Insert(index ,num);
                }
            }
            Console.WriteLine(String.Join(" ",input));
        }
    }
}
