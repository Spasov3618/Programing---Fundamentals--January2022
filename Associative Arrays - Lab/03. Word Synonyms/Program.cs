using System;
using System.Collections.Generic;
using System.Linq;


namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте програма, която поддържа речник със синоними. Ключът на речника ще бъде думата. Стойността ще бъде списък на всички синоними на тази дума. Ще ви бъде дадено число n – броят на думите.След всяка дума ще ви бъде даден синоним, така че броят на редовете, които трябва да прочетете от конзолата, е 2 * n.Ще получите дума и синоним всеки на отделен ред, както следва:
            //• { word}
            //• { синоним}
            //            Ако получите една и съща дума два пъти, просто добавете новия синоним към списъка.
            //Отпечатайте думите в следния формат:
            //            "{word} - {синоним1, синоним2... синонимN}"
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
              
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                }

                dic[word].Add(sinonim);
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
