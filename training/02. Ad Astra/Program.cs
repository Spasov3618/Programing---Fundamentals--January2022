using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int day = 0;
            int totalCalories = 0;
            string input = Console.ReadLine();
            string pattern = @"([#|\|{1,2}])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})*\1(?<calories>\d{1,5})\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                int calories =(int.Parse)(match.Groups["calories"].Value);
                totalCalories+= calories;
            }
            day = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {day} days!");
            foreach (Match item in matches)
            {
                string name = item.Groups["name"].Value;
                string date = item.Groups["date"].Value;
                string calories = item.Groups["calories"].Value;
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }

        }
    }
}
