using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            string pattern = @"(.)+?>(?<number>[\d]{3})\|(?<lower>[a-z]{3})\|(?<uper>[A-Z]{3})\|(?<sumbol>[^\|]{3})<(\1)+?";

            for (int i = 0; i < n; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if (match.Success)
                {
                    string number = match.Groups["number"].Value;
                    string lower = match.Groups["lower"].Value;
                    string uper = match.Groups["uper"].Value;
                    string sumbol = match.Groups["sumbol"].Value;
                   
                    Console.WriteLine($"Password: {string.Join("",number,lower,uper,sumbol)}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
