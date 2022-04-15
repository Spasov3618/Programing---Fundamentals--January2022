using System;

namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());
            int [] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
            num[i] = number;
            }
            Array.Reverse(num);
            Console.WriteLine(String.Join(" ", num));
        }
    }
}
