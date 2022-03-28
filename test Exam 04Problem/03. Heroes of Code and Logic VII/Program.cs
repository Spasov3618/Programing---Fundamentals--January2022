using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            Hp = hp;
            Mp = mp;
        }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //- един герой може да има максимум 100 HP и 200 MP



            //„Презареждане – { име на герой} – { сума}“
            //• Героят увеличава своя MP. Ако изведе MP на героя над максималната стойност(200), MP се увеличава на 200. (MP не може да надхвърли максималната стойност).
            //• Отпечатайте следното съобщение:
            //„{ hero name} презаредено за { amount recovered} MP!“
            //„Излекуване – { име на герой} – { сума}“
            //• Героят увеличава HP.Ако бъде дадена команда, която би довела HP на героя над максималната стойност(100), HP се увеличава на 100(HP не може да надхвърли максималната стойност).
            //• Отпечатайте следното съобщение:
            // "{hero name} излекуван за {amount recovered} HP!"

            //Изход
            //• Отпечатайте всички членове на вашата група, които са все още живи, в следния формат(техните HP/ MP трябва да бъдат отстъпени с 2 интервала):
            //"{име на герой}
            //  HP: { current HP}
            //        MP: { current MP}"
            List<Hero> hero = new List<Hero>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Hero newHero = new Hero(input[0], int.Parse(input[1]), int.Parse(input[2]));
                hero.Add(newHero);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arg = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (arg[0] == "CastSpell")
                {
                    Hero search = hero.FirstOrDefault(x => x.Name == arg[1]);
                    int mp = int.Parse(arg[2]);
                    string word = arg[3];
                    if (search.Mp >= mp)
                    {
                        search.Mp -= mp;
                        Console.WriteLine($"{arg[1]} has successfully cast {word} and now has {search.Mp} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{arg[1]} does not have enough MP to cast {word}!");
                        
                    }
                }
                else if (arg[0] == "TakeDamage")
                {
                    int hp = int.Parse(arg[2]);
                    string atac = arg[3];
                    Hero search = hero.FirstOrDefault(x => x.Name == arg[1]);
                    search.Hp -= hp;
                    if (search.Hp <= 0)
                    {
                        hero.Remove(search);
                        Console.WriteLine($"{arg[1]} has been killed by {atac}!");
                    }
                    else
                    {
                        Console.WriteLine($"{arg[1]} was hit for {hp} HP by {atac} and now has {search.Hp} HP left!");
                    }
                }
                else if (arg[0] == "Recharge")
                {
                    int mp = int.Parse(arg[2]);
                    Hero search = hero.FirstOrDefault(x => x.Name == arg[1]);
                    if (search.Mp + mp > 200)
                    {
                        int recharge = 200 - search.Mp;
                        search.Mp = 200;
                        Console.WriteLine($"{arg[1]} recharged for {recharge} MP!");
                    }
                    else
                    {
                        search.Mp += int.Parse(arg[2]);
                        Console.WriteLine($"{arg[1]} recharged for {mp} MP!");
                    }
                }
                else if (arg[0] == "Heal")
                {
                    int hp = int.Parse(arg[2]);
                    Hero search = hero.FirstOrDefault(x => x.Name == arg[1]);
                    if (search.Hp + hp > 100)
                    {
                        int recharge = 100 - search.Hp;
                        search.Hp = 100;
                        Console.WriteLine($"{arg[1]} healed for {recharge} HP!");
                    }
                    else
                    {
                        search.Hp += int.Parse(arg[2]);
                        Console.WriteLine($"{arg[1]} healed for {hp} HP!");
                    }
                }
            }
            //{hero name}
            //HP: { current HP}
            //MP: { current MP}
            foreach (var item in hero)
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"  HP: {item.Hp}");
                Console.WriteLine($"  MP: {item.Mp}");
            }

        }
    }
}
