using System;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] items = new double[input.Length];
            for (int i = 0; i < input.Length; i++)

            {
                items[i] = double.Parse(input[i]);
                if (items[i]== -0.00)
                {
                    items[i] = 0;
                }
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} => {Math.Round(items[i],MidpointRounding.AwayFromZero)}");
                
            }
           
        }
    }
}
