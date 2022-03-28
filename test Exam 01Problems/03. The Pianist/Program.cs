using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Piece
    {
        public Piece(string name,string composer,string key)
        {
            NamePiece = name;
            Composer = composer;
            Key = key;
        }

        public string NamePiece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред на стандартния вход ще получите цяло число n – броят парчета, които първоначално ще имате.На следващите n реда самите пиеси ще следват с техния композитор и ключ, разделени с "|" в следния формат: "{piece}|{composer}|{key}".
            //След това ще получавате различни команди, всяка на нов ред, разделени с "|", докато не бъде дадена командата "Стоп":
            //• "Добавяне|{piece}|{composer}|{key}":
            //o Трябва да добавите даденото парче с информацията за него към другите парчета и да отпечатате:
            //„{ piece} от { composer} в { key} е добавен към колекцията!“
            //o Ако парчето вече е в колекцията, отпечатайте:
            //„{ piece} вече е в колекцията!“
            //• „Премахване |{ piece}“:
            //o Ако парчето е в колекцията, извадете го и отпечатайте:
            //„{ piece} е премахнат успешно!“
            //o В противен случай отпечатайте:
            //„Невалидна операция! { piece} не съществува в колекцията.“
            //• "ChangeKey|{piece}|{нов ключ}":
            //o Ако парчето е в колекцията, сменете ключа му с дадения и отпечатайте:
            //„Промених ключа на { piece} на { нов ключ}!“
            //o В противен случай отпечатайте:
            //„Невалидна операция! { piece} не съществува в колекцията.“
            //След като получите командата "Стоп", трябва да отпечатате всички парчета от вашата колекция, сортирани по тяхното име и по името на техния композитор по азбучен ред, в следния формат:
            //„{ Piece} -> Композитор: { composer}, Ключ: { key}“
            //Вход / Ограничения
            //• Първоначално ще получите едно цяло число – първоначалния брой парчета в колекцията
            //• За всяко парче ще получите един ред текст с информация за него.
            //• След това ще получите множество команди по описания по - горе начин до командата "Стоп".
            //Изход
            //• Всички изходни съобщения с подходящи формати са описани в описанието на проблема.
            List<Piece> pieces = new List<Piece>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string composer = input[1]; 
                string key = input[2];

              Piece peces = new Piece(name, composer, key);
                pieces.Add(peces);  
            }
            string command;
            while ((command = Console.ReadLine())!= "Stop")
            {
                string[] arg = command.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = arg[0];
                if (action == "Add")
                {
                    string name = arg[1];
                    string composer = arg[2];
                    string key = arg[3];
                    if (!pieces.Any(x => x.NamePiece == name))
                    {
                        Piece peces = new Piece(name, composer, key);
                        pieces.Add(peces);
                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string name = arg[1];
                    Piece search = pieces.FirstOrDefault(x => x.NamePiece == name);
                    if (search != null)
                    {
                        pieces.Remove(search);
                        Console.WriteLine($"Successfully removed {name}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string name = arg[1];
                    string newkey = arg[2];
                    Piece search = pieces.FirstOrDefault(x => x.NamePiece == name);
                    if (search == null)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                    else
                    {
                        search.Key = newkey;
                        Console.WriteLine($"Changed the key of {name} to {newkey}!");
                    }
                }
            }
          //  сортирани по тяхното име и по името на техния композитор по азбучен ред, в следния формат:
            //„{ Piece} -> Композитор: { composer}, Ключ: { key}
           // pieces = pieces.OrderBy(x => x.NamePiece).ThenBy(x => x.Composer).ToList();
            foreach (var item in pieces)
            {
            Console.WriteLine($"{item.NamePiece} -> Composer: {item.Composer}, Key: {item.Key}");

            }
        }
    }
}
