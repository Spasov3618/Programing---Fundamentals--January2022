using System;
using System.Linq;

namespace Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrya = Console.ReadLine().Split().Select(int.Parse ).ToArray(); 
            int[] secondArrya = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < firstArrya.Length; i++)
            {
                    sum += firstArrya[i];
                if (firstArrya[i] != secondArrya[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    flag = true;
                    break;
                }
               

               
             
            }
            if (! flag)
            {

                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
