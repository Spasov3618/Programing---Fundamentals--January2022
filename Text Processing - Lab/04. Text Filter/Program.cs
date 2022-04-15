using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string [] word = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            foreach (var item in word)
            {
            while (input.Contains(item))
                {
                int index = input.IndexOf(item);
                input = input.Replace(item, new string( '*' ,item.Length)) ;

                }

            
            }
            Console.WriteLine(input);
        }
    }
}
