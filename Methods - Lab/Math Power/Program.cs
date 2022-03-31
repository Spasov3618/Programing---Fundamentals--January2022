using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(raistopawer(number,power));
        }
        static double raistopawer(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
