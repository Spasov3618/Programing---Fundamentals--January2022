using System;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char finishSymbol = char.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int symbol = (int)word[i];
                if (symbol> startSymbol && symbol< finishSymbol)
                {
                    sum += symbol;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
