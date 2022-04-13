using System;
using System.Collections.Generic;
using System.Linq;
{

}

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> timeRace = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                double timeRaceRight = 0;
                double timeRaceLeft = 0;
            for (int i = 0; i < timeRace.Count/2; i++)
            {
                if (timeRace[i]==0)
                {
                    timeRaceLeft *= 0.8;
                    timeRaceLeft += timeRace[i];

                }
            }
            for (int i = timeRace.Count - 1; i >= timeRace.Count/2; i--)
            {
                if (timeRace[i] == 0) 
                {
                    timeRaceRight *= 0.8;
                    timeRaceRight += timeRace[i];

                }

            }
            if (timeRaceLeft< timeRaceRight)
            {
                Console.WriteLine($"The winner is left  with total time: {timeRaceLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right  with total time: {timeRaceRight}");
            }
        }
    }
}
