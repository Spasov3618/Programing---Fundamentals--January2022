using System;

namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            for (int i = 1; i < height; i++)
            {
               prindLine(1,i);
            }
            for (int i= height;  i >= 1;i --)
            {
                prindLine(1,i);
            }
        }
        static void prindLine (int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
