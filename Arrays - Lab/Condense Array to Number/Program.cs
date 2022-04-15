using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();

            int first = input.Length;

            // 1 2 3
            // 3 5
            // 8
            // length - 1

            for (int i = 0; i < first - 1; i++)
            {
                int[] condensed = new int[input.Length - 1];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    condensed[j] = input[j] + input[j + 1];
                }

                input = condensed;
            }

            Console.WriteLine(input[0]);
        }
    }
}
