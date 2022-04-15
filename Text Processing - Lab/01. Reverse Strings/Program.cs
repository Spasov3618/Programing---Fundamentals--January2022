using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                string revers = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    revers += word[i];
                }
                Console.WriteLine($"{word} = {revers}");
            }
               

            

              
        }
    }
}
