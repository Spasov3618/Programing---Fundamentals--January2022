using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string winningSymbolsRegex = @"(\${6,10}|\@{6,10}|\#{6,10}|\^{6,10})";
            List<string> input = Console.ReadLine().Trim().Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                string currentTicket = input[i];

                if (currentTicket.Length != 20)
                {
                    sb.AppendLine("invalid ticket");
                    continue;
                }

                else if (!Regex.IsMatch(currentTicket, winningSymbolsRegex))
                {
                    sb.AppendLine($"ticket \"{currentTicket}\" - no match");
                }

                else if (Regex.IsMatch(currentTicket, winningSymbolsRegex))
                {
                    Match match = Regex.Match(currentTicket, winningSymbolsRegex);
                    string leftHalf = string.Join("", currentTicket.Take(10));
                    string rightHalf = string.Join("", currentTicket.Skip(10).Take(10));
                    leftHalf = Regex.Match(leftHalf, winningSymbolsRegex).Value;
                    rightHalf = Regex.Match(rightHalf, winningSymbolsRegex).Value;
                    int leftSymbolCount = leftHalf.Count(x => x == match.Value[0]);
                    int rightSymbolCount = rightHalf.Count(x => x == match.Value[0]);
                    int min = Math.Min(leftSymbolCount, rightSymbolCount);

                    if (min == 10)
                    {
                        sb.AppendLine($"ticket \"{currentTicket}\" - {min}{match.Value[0]} Jackpot!");
                    }
                    else if (leftSymbolCount == 0 || rightSymbolCount == 0)
                    {
                        sb.AppendLine($"ticket \"{currentTicket}\" - no match");
                    }
                    else
                    {
                        sb.AppendLine($"ticket \"{currentTicket}\" - {min}{match.Value[0]}");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
