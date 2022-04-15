using System;

namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] input = Console.ReadLine().Split(' ');
           Array.Reverse(input);

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
