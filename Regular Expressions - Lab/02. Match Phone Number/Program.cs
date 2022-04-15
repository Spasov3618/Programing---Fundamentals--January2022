﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);
            List<string> result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", result));

            //string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            //string input = Console.ReadLine();

            //MatchCollection matches = Regex.Matches(input, pattern);
            //List<string> result = new List<string>();

            //foreach (Match item in matches)
            //{
            //    result.Add(item.Value);
            //}

            //Console.WriteLine(string.Join(", ", result));

        }

    }
    }

