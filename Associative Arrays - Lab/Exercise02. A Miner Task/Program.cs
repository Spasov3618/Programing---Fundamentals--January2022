using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<string,int> dic = new Dictionary<string,int>();
            string resource;
            while ((resource=Console.ReadLine()) != "stop")
            
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!dic.ContainsKey(resource))
                {
                    dic.Add(resource, 0);
                }
                dic[resource] += quantity;
            }
            foreach (var item in dic)
            {
            Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
