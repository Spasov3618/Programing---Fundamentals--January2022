using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input = Console.ReadLine();    
            int sum = 1;
            string pattern = @"[0-9]";
           MatchCollection matches = Regex.Matches(input, pattern);
         List<string> rezult = new List<string>();
            foreach (Match match in matches)
            {
                sum*=int.Parse(match.Value);
            }
            string pattern1 = @"([:]{2}|[*]{2})[A-z][a-z]{2,}\1";
            //@"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            MatchCollection match1 = Regex.Matches(input, pattern1);    
            foreach (Match item in match1)
            {
                int valio = 0;
                for (int i = 0; i < item.Value.Length; i++)
                {
                   char c = item.Value[i];
                    if (char.IsLetter (c))
                    {
                        valio += (int)c;
                    }

                }
                if (valio>sum)
                {
                    rezult.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{match1.Count} emojis found in the text. The cool ones are:");
            foreach (var item in rezult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
