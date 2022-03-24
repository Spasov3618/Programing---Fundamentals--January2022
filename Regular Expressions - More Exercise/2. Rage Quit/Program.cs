using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           StringBuilder output = new StringBuilder();
            string pattern = @"\D+\d+";
            string contains = "";
            int counter = 0;
            MatchCollection match = Regex.Matches(input, pattern);
            foreach (Match m in match)
            {
                string word = m.Value.ToUpper();
                
            string patternDigit = @"[0-9]+";
           Match match1 = Regex.Match(word, patternDigit);
                int counterDigit = int.Parse(match1.Value);

                for (int i = 0; i < counterDigit; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                       
                        if (!char.IsDigit(word[j]))
                        {
                        if (!contains.Contains(word[j]))
                        {
                            counter++;
                            contains += (word[j]);
                        }
                        output.Append(word[j]); 
                        }

                    }

                }
            }
            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine(output);
        }
    }
}
