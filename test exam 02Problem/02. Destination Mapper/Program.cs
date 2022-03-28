using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> exhibition = new Dictionary<string, int>();
            Dictionary<string, List<double>> rating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");

                if (!exhibition.ContainsKey(input[0]))
                {
                    exhibition.Add(input[0], int.Parse(input[1]));
                }
                else
                {
                    exhibition.Remove(input[0]);
                    exhibition.Add(input[0], int.Parse(input[1]));
                }
            }

            string[] command = Console.ReadLine().Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Exhibition")
            {

                if (command[0] == "Rate")
                {
                    if (exhibition.ContainsKey(command[1]))
                    {
                        if (!rating.ContainsKey(command[1]))
                        {
                            rating.Add(command[1], new List<double>());
                        }
                        rating[command[1]].Add(double.Parse(command[2]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Update")
                {
                    if (exhibition.ContainsKey(command[1]))
                    {
                        exhibition.Remove(command[1]);
                        exhibition.Add(command[1], int.Parse(command[2]));
                    }
                    else          //changed
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (command[0] == "Reset")
                {
                    if (rating.ContainsKey(command[1]))
                    {
                        rating.Remove(command[1]);
                        //rating.Add(command[1], new List<double> { 0 }); //deleted
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                command = Console.ReadLine().Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, List<double>> union = new Dictionary<string, List<double>>();

            foreach (var item in exhibition)
            {
                string key = item.Key;
                int rarity = item.Value;

                union.Add(key, new List<double>());
                union[key].Add(rarity);
                if (rating.ContainsKey(key))   //changed
                {                               //changed
                    union[key].Add(rating[key].Average());  //changed
                    continue;                               //changed
                }                                           //changed
                union[key].Add(0);                          //changed
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in union)
            {
                Console.WriteLine($" - {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}