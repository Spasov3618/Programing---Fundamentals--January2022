using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Join(string.Empty, Console.ReadLine().Split());
            Dictionary<char,int> output = new Dictionary<char,int>();
            foreach (var item in text)
            {
                if (!output.ContainsKey(item))
                {
                    output.Add(item, 0);
                }

                output[item]++;

            }

            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
        
    }
}
