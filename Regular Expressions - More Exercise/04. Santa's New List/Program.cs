using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дядо Коледа трябва да започне да създава своя нов списък за следващата Коледа.Вашата задача е да му помогнете да получи и запази входящата информация. Той ще получи информация за имената на децата, вида подарък, който искат(играчка, бонбони, дрехи) и желаната сума в следния формат:
            //{ childName}->{ typeOfToy}->{ amount}
            //Можете да получите команда „Remove->{ childName}“. В този случай трябва да изключите детето от новия списък с добри деца, но не променяйте информацията за вида подарък, който желае, и желаната сума. Дядо Коледа вече е получил подаръците, така че може да ги подари на друго много добро дете.
            //Когато получите командата “КРАЙ”, трябва да я обработите и да я отпечатате, подредени в низходящ ред по общия брой подаръци за дете и след това по имената им.Форматът е даден по-долу.
            //Вход
            //Докато не получите команда "КРАЙ", ще получавате информация за желаните подаръци в следния формат:
            // „{ childName}->{ typeOfPresent}->{ amount}“.
            //Можете да получите команда за премахване на дете от списъка -> "Премахване->{childName}"
            //Изход
            //• Отпечатайте подаръците за всяко дете, подредени в низходящ ред по общата сума и след това по името им, в следния формат:
            //деца:
            //{ childName} -> { points}
            //• След този тип печат на подаръка и общия брой за него в следния формат:
            //представя:
            //{ type} –> { count}
            Dictionary<string,int> children = new Dictionary<string,int>();
            Dictionary<string,int> toys = new Dictionary<string,int>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arg = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string name = arg[0];
                if (name == "Remove")
                {
                    string removeName = arg[1];
                    children.Remove(removeName);
                }
                else
                {
                        string toy = arg[1];
                        int num = int.Parse(arg[2]);
                    if (!children.ContainsKey(name))
                    {
                        children.Add(name, num);
                    }
                    else
                    {
                        children[name] += num;
                    }
                    if (!toys.ContainsKey(toy))
                    {
                        toys.Add(toy, num);

                    }
                    else
                    {

                        toys[toy] += num;
                    }


                }
            }
           //children.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("Children:");
            foreach (var item in children.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var item in toys) 
            {
            Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
