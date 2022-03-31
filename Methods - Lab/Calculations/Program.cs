using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (command)
            {
                //add", "multiply", "subtract", "divide"
                case "add":
                    collection(a, b);
                    break;
                case "multiply":
                    multiplay(a, b);
                    break;
                case "divide":
                    divide(a, b);
                    break;
                case "subtract":
                    subtraction(a, b);
                    break;
            }

        }
        static void multiplay(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void collection (int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void subtraction (int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
}
