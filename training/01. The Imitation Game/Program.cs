using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] arg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string move = arg[0];
                if (move == "Move")
                {
                    int num = int.Parse(arg[1]);
                    string subString = input.Substring(0,num);
                    input = input.Remove(0,subString.Length);
                    input +=string.Join("", subString);
                }
                else if (move == "Insert")
                {
                    int index = int.Parse(arg[1]);
                    string newString = arg[2];
                    input= input.Insert(index, newString);
                }
                else if (move == "ChangeAll")
                {
                    string changeChar = arg[1];
                    string newChar = arg[2];
                    input = input.Replace(changeChar, newChar);
                }
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
