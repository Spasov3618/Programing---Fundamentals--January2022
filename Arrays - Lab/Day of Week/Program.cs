using System;
using System.Linq;

namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse (Console.ReadLine());
            string[] day = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (num > 0 && num <=7)
            {
                Console.WriteLine(day[num-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
