using System;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(repeatString(input,num));
            static string repeatString(string input, int num)
            {
                string rezult = string.Empty;
                for (int i = 0; i < num; i++)
                {
                    rezult += input.ToString();
                }
                return rezult;
            }
        }
    }
}
