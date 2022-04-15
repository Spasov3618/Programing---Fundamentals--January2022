using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string,int> map = new Dictionary<string,int>();

            Regex patternName =new Regex(@"(?<name>[A-Za-z]+)");
            string patternKm = @"(?<km>[0-9]+)";
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                var matchName = patternName.Matches(input);
                var name = string.Join("", matchName);
                if (list.Contains(name))
                {
                    int sum = 0;
                    MatchCollection matchKm = Regex.Matches(input, patternKm);
                    var km = string.Join("", matchKm);
                    for (int i = 0; i < km.Length; i++)
                    {
                        sum += int.Parse(km[i].ToString());
                       
                    }
                        
                        
                    if (!map.ContainsKey(name))
                    {
                        map.Add(name, sum);
                    }
                    else
                    {
                    map[name] += sum;

                    }
                }
            }
            
            var rezult = map.OrderByDescending(x => x.Value).Take(3);
            var first = rezult.Take(1);
            var second = rezult.OrderByDescending(x =>x.Value).Take(2).OrderBy(x => x.Value).Take(1);    
            var third = rezult.OrderBy(x => x.Value).Take(1); ;
            foreach (var item in first)
            {
            Console.WriteLine($"1st place: {item.Key}");

            }
            foreach (var item in second)
            {

            Console.WriteLine($"2nd place: {item.Key}");
            }
            foreach (var item in third)
            {

            Console.WriteLine($"3rd place: {item.Key}");
            }
            
        }
    }
}
