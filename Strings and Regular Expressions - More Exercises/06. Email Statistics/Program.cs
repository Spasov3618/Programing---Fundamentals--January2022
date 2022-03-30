using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06._Email_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^(?<username>[A-Za-z]{5,})@(?<domein>[a-z]{3,}\.[bg|com|org]+)$";
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["username"].Value;
                    string domein = match.Groups["domein"].Value;
                    if (!dic.ContainsKey(domein))
                    {
                        dic.Add(domein, new List<string>());
                    }
                    if (!dic[domein].Contains(name))
                    {
                        dic[domein].Add(name);

                    }
                }
            }
            dic = new Dictionary<string, List<string>>(dic.OrderByDescending(x => x.Value.Count));
            //{ 1st domain}:
            //### {1st username}
            //### {2nd username}
            //…
            //### {nth username}
            //…
            //{ nth domain}
            //### {1st username}
            //…
            //### {nth username}
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var name in item.Value)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
