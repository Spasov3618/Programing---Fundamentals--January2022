using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> maxLength = new List<int>();

            for (int i = 0; i < n.Length; i++)
            {
                List<int> numbers = new List<int>();
                numbers.Add(n[i]);

                for (int j = i + 1; j < n.Length; j++)
                {

                    if (j == n.Length - 2)
                    {
                        if ((n[j] < numbers[numbers.Count - 1] && n[n.Length - 1] < numbers[numbers.Count - 1]))
                        {
                            if (numbers.Count > 1)
                            {
                                if ((n[j] > numbers[numbers.Count - 2] && n[n.Length - 1] > numbers[numbers.Count - 2]))
                                {
                                    if (n[n.Length - 1] > n[j])
                                    {
                                        numbers.RemoveAt(numbers.Count - 1);
                                        numbers.Add(n[j]);
                                        numbers.Add(n[n.Length - 1]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (n[j] > numbers[numbers.Count - 1])
                            {
                                numbers.Add(n[j]);
                            }
                            if (n[n.Length - 1] > numbers[numbers.Count - 1] && n[n.Length - 1] > n[j])
                            {

                                numbers.Add(n[n.Length - 1]);
                            }

                        }
                        break;
                    }
                    else
                    {
                        byte count = 0;

                        for (int c = 0; c < numbers.Count; c++)
                        {
                            if (n[j] > numbers[c])
                            {
                                count = 1;
                            }
                            else if (n[j] == numbers[c])
                            {
                                count = 0;
                            }
                            else
                            {
                                if (count == 1)
                                {
                                    numbers.RemoveAt(c);
                                }
                            }
                        }
                        if (count == 1)
                        {
                            numbers.Add(n[j]);
                        }

                    }

                }
                //Console.WriteLine(string.Join(" ",numbers));
                if (numbers.Count > maxLength.Count)
                {
                    maxLength = numbers.ToList();
                }
            }
            Console.WriteLine(string.Join(" ", maxLength));
        }
    }
}