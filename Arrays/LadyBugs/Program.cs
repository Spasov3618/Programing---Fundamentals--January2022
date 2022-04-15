using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counters = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries) .Select(int.Parse).ToArray();



            int[] ladybugsArr = new int[counters];



            for (int i = 0; i < initialIndexes.Length; i++)

            {

                if (initialIndexes[i] >= 0 && initialIndexes[i] < ladybugsArr.Length)

                {

                    ladybugsArr[initialIndexes[i]] = 1;

                }

            }



            string input = string.Empty;



            while ((input = Console.ReadLine()) != "end")

            {

                string[] command = input.Split();



                int ladybugIndex = int.Parse(command[0]);

                string direction = command[1];

                int flyLength = int.Parse(command[2]);



                if (ladybugIndex >= 0 && ladybugIndex < ladybugsArr.Length && ladybugsArr[ladybugIndex] == 1)

                {

                    ladybugsArr[ladybugIndex] = 0;



                    if (direction == "left")

                    {

                        flyLength = -flyLength;

                    }



                    while (true)

                    {

                        if (ladybugIndex + flyLength >= ladybugsArr.Length || ladybugIndex + flyLength < 0)

                        {

                            break;

                        }



                        if (ladybugsArr[ladybugIndex + flyLength] == 0)

                        {

                            ladybugsArr[ladybugIndex + flyLength] = 1;

                            break;

                        }



                        flyLength += flyLength;

                    }

                }

            }



            Console.WriteLine(string.Join(" ", ladybugsArr));

        }
    }
}
