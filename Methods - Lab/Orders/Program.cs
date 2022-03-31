using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            orders(product,num);
        }
        static void orders(string product, int num)
        {
            switch (product)
            {
                //•	coffee – 1.50
                //•	water – 1.00
                //•	coke – 1.40
                //•	snacks – 2.00

                case "coffee":
                    Console.WriteLine($"{num*1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{num*1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{num*1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{num * 2.00:f2}");
                    break;
            }
        }
    }
}
