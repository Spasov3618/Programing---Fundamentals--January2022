using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1= Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2= Console.ReadLine().Split().Select(int.Parse).ToList();
            int lenght = Math.Min(list1.Count, list2.Count);
            List<int>arr = new List<int>();
            for (int i = 0; i < lenght; i++)
            {
               arr.Add(list1[0]);
                list1.Remove(list1[0]);
                arr.Add(list2[list2.Count-1]);
                list2.RemoveAt(list2.Count - 1);
                
            }
            
            if (list1.Count>list2.Count)
            {
                list1.Sort();
                int start = list1[0];
                int end = list1[1];
                arr.RemoveAll(x => (x<=start || x>=end));
            }
            else if (list1.Count<list2.Count)
            {
                list2.Sort();
                int start = list2[0];
                int end = list2[1];
                arr.RemoveAll(x => (x <= start || x >= end));
            }
            arr.Sort();
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
