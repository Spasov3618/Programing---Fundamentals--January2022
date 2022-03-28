using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int num = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < num; i++)
            {
                double priceCoffe = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int numCoffe = int.Parse(Console.ReadLine());   
                double sum = day*numCoffe * priceCoffe ;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                total += sum;
                sum = 0;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
