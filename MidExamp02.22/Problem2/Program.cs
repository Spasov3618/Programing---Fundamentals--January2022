using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr= Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int counter = 0;
            int lostCounter = 0;

            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] camand = input.Split().ToArray();

                if (camand[0] == "Blacklist")
                {
                    string name = camand[1];

                    if (CheckName(arr, name))
                    {
                        counter++;
                    }

                    BlacklistName(arr, name);
                }
                else if (camand[0] == "Error")
                {
                    int index = int.Parse(camand[1]);

                    if (index >= 0 && index < arr.Length)
                    {
                        if (arr[index] != "Blacklisted" && arr[index] != "Lost")
                        {
                            lostCounter++;
                            Console.WriteLine($"{arr[index]} was lost due to an error.");
                            arr[index] = "Lost";
                        }
                    }
                }
                else if (camand[0] == "Change")
                {
                    int index = int.Parse(camand[1]);
                    string newName = camand[2];

                    if (index >= 0 && index < arr.Length)
                    {
                        if (arr[index] != "Blacklisted" && arr[index] != "Lost")
                        {
                            Console.WriteLine($"{arr[index]} changed his username to {newName}.");
                            arr[index] = newName;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {counter}");
            Console.WriteLine($"Lost names: {lostCounter}");
            Console.WriteLine(String.Join(" ", arr));
        }

        static void BlacklistName(string[] names, string name)
        {
            bool flag = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    flag = true;
                    Console.WriteLine($"{names[i]} was blacklisted.");
                    names[i] = "Blacklisted";
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{name} was not found.");
            }
        }

        static bool CheckName(string[] names, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
