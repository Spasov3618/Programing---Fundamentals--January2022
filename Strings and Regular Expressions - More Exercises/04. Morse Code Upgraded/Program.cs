using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Morse_Code_Upgraded
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            int total = 0;
            string output = "";
            

            for (int i = 0; i < input.Length; i++)
            {
            int counterOne = 0;
            int counterZero = 0;
            int counter = 0;
                string word = input[i];
                string pattern = @"(\d)\1+";
                MatchCollection match = Regex.Matches(word, pattern);
                foreach (Match item in match)
                {
                    counter += item.Value.Length;
                }


                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == '1')
                    {
                        counterOne++;
                    }
                    else if (word[j] == '0')
                    {
                        counterZero++;
                    }
                                                         
                }
               
                    

                total = (counterZero * 3) + (counterOne * 5)+counter;
                output += (char)(total);
            }
            Console.WriteLine(output);
        }
    }
}
