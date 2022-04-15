using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arraysOne = Console.ReadLine().Split(" ");
            string[] arraysTwo = Console.ReadLine().Split(" ");

            foreach (var item in arraysTwo)
            {
                foreach (var itemTwo in arraysOne)
                {
                    if (item == itemTwo)
                    {
                        Console.Write(item + " ");
                    }
                }
            }          
        }
    }
}
