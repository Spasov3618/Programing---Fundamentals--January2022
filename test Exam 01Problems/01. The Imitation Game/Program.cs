using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string word = Console.ReadLine();
            List <char> list2 = new List <char>(word);
            string  command;
            while ((command  =Console.ReadLine()) != "Decode")
            {
                string [] arg = command.Split("|");
                string action = arg[0];
                if (action == "Move")
                {
                    int num = int.Parse(arg[1]);
                    for (int i = 0; i < num; i++)
                    {
                        list2.Add(list2[0]);
                        list2.Remove(list2[0]);
                        
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(arg[1]);
                    string value = arg[2];
                    list2.InsertRange (index , value);
                }
                else if (action == "ChangeAll")
                {
                    char symbol = char.Parse(arg[1]);
                    char withSymbol = char.Parse (arg[2]);
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (list2[i] == symbol)
                        {
                            list2.RemoveAt(i);
                            list2.Insert(i , withSymbol);
                        }
                    }

                }
            }
            Console.Write("The decrypted message is: ");
                Console.WriteLine(string.Join("",list2));
           
        }
    }
}
