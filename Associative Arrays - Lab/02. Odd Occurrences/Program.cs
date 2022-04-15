using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string,int> rezult = new Dictionary<string,int>();
            foreach (var item in input)
            {
                string sortedRezult = item.ToLower();
                if (rezult.ContainsKey(sortedRezult))
                {
                    rezult[sortedRezult]++;
                }
                else
                {
                    rezult.Add(sortedRezult, 1);

                }
            }
            foreach (var item in rezult)
            {
                if (item.Value %2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
