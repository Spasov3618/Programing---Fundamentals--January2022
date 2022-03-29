using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                var end = arr[0];
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = end;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
