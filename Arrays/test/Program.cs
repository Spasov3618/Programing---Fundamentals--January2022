using System;
using System.Linq;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Max());
        }
    }
}
