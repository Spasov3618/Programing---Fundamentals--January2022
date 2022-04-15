using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOfLines = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    string currentLine = Console.ReadLine();

            //    int indexBeforeTheName = currentLine.IndexOf('@');
            //    int indexAfterOfTheName = currentLine.IndexOf('|');

            //    string name = currentLine.Substring(indexBeforeTheName + 1, indexAfterOfTheName -
            //        indexBeforeTheName - 1);

            //    int indexBeforeTheAge = currentLine.IndexOf('#');
            //    int indexAfterTheAge = currentLine.IndexOf('*');

            //    string age = currentLine.Substring(indexBeforeTheAge + 1, indexAfterTheAge - indexBeforeTheAge - 1);

            //    Console.WriteLine($"{name} is {age} years old.");
            //}

            int n = int.Parse(Console.ReadLine());


            Regex namePattern = new Regex(@"@(?<name>[\S\s]*?)\|");
            Regex agePattern = new Regex(@"#(?<age>[\S\s]*?)\*");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (namePattern.IsMatch(input) && agePattern.IsMatch(input))
                {
                    Console.WriteLine($"{namePattern.Match(input).Groups["name"].ToString()} is {agePattern.Match(input).Groups["age"].ToString()} years old.");
                }
            }
        }
    }

}
