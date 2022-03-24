using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key =int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string decript = "";
                for (int i = 0; i < input.Length; i++)
                {
                    decript += (char)(input[i] - key);
                }
                string pattern = @"@(?<name>[A-Za-z]+)([^-@!:>]+)?!(?<rezult>[G|N])!";
            MatchCollection matchRezult = Regex.Matches(decript, pattern,RegexOptions.IgnoreCase);
                 Match matchRez = Regex.Match(decript, pattern,RegexOptions.IgnoreCase);
               string name = matchRez.Groups["name"].Value;
                string rezult = matchRez.Groups["rezult"].Value;
                if (rezult== "G")
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
