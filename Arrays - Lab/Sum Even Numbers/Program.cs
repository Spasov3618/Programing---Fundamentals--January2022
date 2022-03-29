using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] num = Console.ReadLine().Split(' ').Select(int.Parse ).ToArray();
            int sum = 0;
            foreach (var item in num)

            {
                if (item%2==0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
