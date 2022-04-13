using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред ще получим списък с вагони(цели числа). Всяко цяло число представлява броя на пътниците, които в момента се намират във всеки вагон на пътнически влак.На следващия ред ще получите максималния капацитет на вагон, представен като едно цяло число.Докато не получите командата "end", ще получавате два типа вход:
            //• Добавяне на { passengers} – добавете вагон към края на влака с дадения брой пътници.
            //• { passengers}
            //-намерете един вагон, който да побере всички входящи пътници(започвайки от първия вагон).
            //Накрая отпечатайте крайното състояние на влака(всички вагони разделени с интервал). 
            List<int> train = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string comand;
            while ((comand=Console.ReadLine()) != "end")
            {
                string[] token = comand.Split();
                if (token[0]== "Add")
                {
                    train.Add(int.Parse(token[1]));
                }
                else
                {
                    int pasandjer = int.Parse(token[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + pasandjer <= capacity)
                        {
                            train[i] += pasandjer;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
                
            }
        }
