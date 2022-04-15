using System;
using System.Linq;

namespace Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int [] n = new int[input.Length];
            int num = int.MinValue;
            int index = 0;
            for (int i = input.Length - 1; i >= 0; i--)

            {
                if (input[i] > num)
                {
                  n[index] = input[i];
                  num = input[i];
                      index++;
                    
                }
                
           
            }
            for (int m = index-1; m >=0; m--)
            {
                Console.Write($"{n[m] } ");
            }

                }
            }
        }
    
