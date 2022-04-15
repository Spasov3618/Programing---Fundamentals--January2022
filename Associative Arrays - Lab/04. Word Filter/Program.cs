using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] word = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length %2 ==0).ToArray();
            foreach (var item in word)
            {
                Console.WriteLine(item);
            }
        }
    }
}
