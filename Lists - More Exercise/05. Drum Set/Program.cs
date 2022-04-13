using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savingMoney = double.Parse(Console.ReadLine());
            List<int> drumSet = Console
                            .ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            List<int> newDrumSet = new List<int>(drumSet);
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {

                

                for (int i = 0; i < newDrumSet.Count; i++)
                {
                    newDrumSet[i] -= int.Parse(command);

                    //bool containsNegative = newDrumSet.Any(i => i < 0);

                    if (newDrumSet[i] <= 0)
                    {
                        //newDrumSet.RemoveAll(i => i < 0);

                        int spendMoney = drumSet[i] * 3;

                        if (spendMoney <= savingMoney)
                        {
                            //newDrumSet.Insert(i, drumSet[i]);
                            newDrumSet[i] = drumSet[i];
                            savingMoney -= spendMoney;
                        }
                        else
                        {
                            drumSet.Remove(drumSet[i]);
                            newDrumSet.Remove(newDrumSet[i]);
                            i--;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newDrumSet));
            Console.WriteLine($"Gabsy has {savingMoney:F2}lv.");
        }
    }
}
