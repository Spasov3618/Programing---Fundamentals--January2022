using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
