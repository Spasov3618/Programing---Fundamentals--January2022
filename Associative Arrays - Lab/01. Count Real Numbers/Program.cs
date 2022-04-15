using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            SortedDictionary < double, double> rezult = new SortedDictionary< double, double>();
            foreach (var item in num)
            {
                if (rezult.ContainsKey(item))
                {
                    rezult[item]++;
                }
                else
                {
                    rezult.Add(item, 1);
                }
            }

            foreach (var item in rezult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
