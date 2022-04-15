using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double power = double.Parse(Console.ReadLine());
            double numBatles= double.Parse(Console.ReadLine());
            double startPower = power;
            int battleCount = 0;

            for (int i = 1; i <= numBatles; i++)
            {
                double numPower = int.Parse(Console.ReadLine());
                 if (i % 3 == 0 )
                {
                    battleCount++;
                    numPower *= 1.15;
                    startPower -= numPower;
                }
                else if(i % 5 == 0 )
                {
                    battleCount++;
                    numPower *= 0.9;
                    startPower -= numPower;
                }
                else if (i % 15 == 0 )
                {
                    battleCount++;
                    numPower *= 1.05;
                    startPower -= numPower;
                }
                else
                {
                    battleCount++;
                    startPower-= numPower;
                }
                if (startPower <= 0)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {startPower:f2} more needed.");
            
        }
    }
}
