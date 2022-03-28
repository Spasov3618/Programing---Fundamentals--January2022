using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"([=/])([A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);

            int travelPoints = 0;

            List<string> listOfDestinations = new List<string>();

            foreach (Match currentMatch in regex.Matches(text))
            {
                travelPoints += currentMatch.Groups[2].Length;
                string currentDestination = currentMatch.Groups[2].Value;
                listOfDestinations.Add(currentDestination);
            }

            string destinations = String.Join(", ", listOfDestinations);

            Console.WriteLine("Destinations: " + destinations);
            Console.WriteLine("Travel Points: " + travelPoints);
        }
    }
}
