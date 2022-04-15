using System;
using System.Text.RegularExpressions;

namespace _05._Only_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\d+";
            MatchCollection match = Regex.Matches(input, pattern);
            foreach (Match m in match)
            {
                int index =input.IndexOf(m.Value);
                int digitLenght = m.Value.Length;
                int indexNewChar = index + digitLenght;
                if (indexNewChar< input.Length)
                {

                string newChar = input[index+ digitLenght].ToString();
                input= input.Replace(m.Value, newChar);
                }


            }
            Console.WriteLine(input);
        }
    }
}
