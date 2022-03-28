using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                bool  match = Regex.IsMatch(input, patern);
                if (match)
                {
                    
                    string productGrup = "";
                    for (int j = 0; j < input.Length; j++)
                    {
                        char c = input[j];
                        if (char.IsDigit(c) || c == '0')
                        {
                            productGrup += c;
                        }

                      
                    }
                    if (productGrup == "")
                    {
                        productGrup = "00";
                    }
                    Console.WriteLine($"Product group: {productGrup}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                                                
                   
            }
        }
    }
}
