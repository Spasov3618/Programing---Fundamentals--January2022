using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //StringBuilder leters = new StringBuilder();
            //StringBuilder numbers = new StringBuilder();
            //StringBuilder other = new StringBuilder();
            char [] leter = word.Where(x => char.IsLetter(x)).ToArray();
            char [] numbers = word.Where(x => char.IsDigit(x)).ToArray();
            char [] oither = word.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            //for (int i = 0; i < word.Length; i++)
            //{
            //    char c = word[i];
            //    if (char.IsLetter(c))
            //    {
            //leters = leters.Append(c);

            //    }
            //    else if (char.IsDigit(c))
            //    {
            //   numbers= numbers.Append(c);

            //    }
            //    else
            //    {

            //   other= other.Append(c);
            //    }

            //}
            Console.WriteLine(numbers);
            Console.WriteLine(leter);
            Console.WriteLine(oither);
        }
    }
}
