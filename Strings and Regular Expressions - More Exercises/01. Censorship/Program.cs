using System;

namespace _01._Censorship
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string word = Console.ReadLine();
            string replacement = new string('*', word.Length);
            string sentence = Console.ReadLine().Replace(word, replacement);
            Console.WriteLine(sentence);
            //Напишете програма, която приема като въвеждане една-единствена дума и изречение.Вашата програма трябва да търси думата в изречението и да замени всяка буква от думата с '*'.Трябва да направите това за всяко появяване на думата. Заменете само думи, които са абсолютно същия случай като дадения на първата редова дума.Забележете, че трябва да замените думата, дори ако тя е част от друга дума.
            //Въвеждане
            //Входът ще се състои от два реда:
            //На първата линия, ще бъде думата, която трябва да цензура.
            //На втората линия, ще бъде изречението, което трябва да цензура.
            //Изход
            //Отпечатайте изречението, след като бъде цензуриран.
           
            
            
            
            //string word = Console.ReadLine();
            //string text = Console.ReadLine();
            //string newWord = "";
            //for (int i = 0; i < word.Length; i++)
            //{
            //    newWord += '*';
            //}

            //while (text.Contains(word))
            //{

            //    text = text.Replace(word,newWord );
            //}
            //Console.WriteLine(text);
        }
    }
}
