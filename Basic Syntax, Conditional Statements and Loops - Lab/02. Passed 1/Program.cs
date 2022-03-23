using System;

namespace _02._Passed_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            if (price >=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
