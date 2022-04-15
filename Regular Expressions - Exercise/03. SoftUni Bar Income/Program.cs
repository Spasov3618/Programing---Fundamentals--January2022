using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^$|%.]*<(?<product>[\w]+)>[^$|%.]*\|(?<guontity>[\d]+)\|[^$|%.]*?(?<price>[\d]+[.]?[\d]+)?\$";
            string input;
            double total = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                bool mathes = Regex.IsMatch(input, pattern);
                if (mathes)
                {
                    string name = Regex.Match(input, pattern).Groups["name"].Value;
                    string product = Regex.Match(input, pattern).Groups["product"].Value;
                    int guantity =int.Parse(Regex.Match(input, pattern).Groups["guontity"].Value);
                    double price =double.Parse(Regex.Match(input, pattern).Groups["price"].Value);
                    double totalPrice = guantity* price;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    total += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
