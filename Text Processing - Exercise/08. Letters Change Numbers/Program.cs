using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;



            foreach (var text in inputs)

            {

                var firstLetter = text[0];

                var lastLetter = text[text.Length - 1];

                var number = double.Parse(text.Substring(1, text.Length - 2));



                if (char.IsUpper(firstLetter))

                {

                    number /= 1 + firstLetter - 'A';

                }

                else if (char.IsLower(firstLetter))

                {

                    number *= 1 + firstLetter - 'a';

                }



                if (char.IsUpper(lastLetter))

                {

                    number -= 1 + lastLetter - 'A';

                }

                else if (char.IsLower(lastLetter))

                {

                    number += 1 + lastLetter - 'a';

                }



                sum += number;

            }



            Console.WriteLine($"{sum:F2}");

        }
    }
}
