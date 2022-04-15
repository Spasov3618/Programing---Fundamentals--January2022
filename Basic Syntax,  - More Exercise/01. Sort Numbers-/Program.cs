using System;
using System.Linq;

namespace _01._Sort_Numbers_
{
    internal class Program
    {
        private static readonly object arrey;

        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int c = int.Parse(Console.ReadLine());

            if (a>=b&&a>=c&&b>=c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            else if (a<=b&&a>=c&&b>=c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else if (a<=b&&a<=c&&b>=c)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
            else if (a>=b&& a<=c&& b<=c)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else if (a<=b&&a<=c&&b<=c)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        
        
        }
    }
}
