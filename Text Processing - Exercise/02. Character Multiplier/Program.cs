using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            char[] char1 = input[0].ToCharArray();
            char[] char2 = input[1].ToCharArray();

            int totalSum = 0;
            for (int i = 0; i < Math.Max(char1.Length, char2.Length); i++)
            {
                if (i < char1.Length && i < char2.Length)
                {
                    totalSum += char1[i] * char2[i];
                }
                else if (i < char1.Length && i >= char2.Length)
                {
                    totalSum += char1[i];
                }
                else if (i >= char1.Length && i < char2.Length)
                {
                    totalSum += char2[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
