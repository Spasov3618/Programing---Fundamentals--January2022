using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
            List<string> input = Regex.Split(Console.ReadLine(), @" *,{1} *")
                      .Select(x => x.Trim())
                    .ToList();
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
            int sumHealth = 0;
                double sumDigit = 0.00;
                string arg = input[i];
                string patternLeters = @"[^\d\+\-\*\/\.]";
                MatchCollection leters = Regex.Matches(arg, patternLeters);
                foreach (Match item in leters)
                {
                    sumHealth += char.Parse(item.Value);
                }




                string patternDigit = @"((|-)\d+\.\d+|(|-)\d+)"; 
                MatchCollection sum = Regex.Matches(arg, patternDigit);
                foreach (Match match in sum)
                {
                    sumDigit += double.Parse(match.Value);
                }

                string pattewnSymbol = @"([\/|*]?)";
                MatchCollection symbol = Regex.Matches(arg, pattewnSymbol);
                foreach (Match match in symbol)
                    if (match.Value == "/")
                    {
                        sumDigit /= 2;
                    }
                else if (match.Value == "*")
                    {
                        sumDigit *= 2;
                    }
                Console.WriteLine($"{arg} - {sumHealth} health, {sumDigit:f2} damage");

            }        

        }
    }
}
