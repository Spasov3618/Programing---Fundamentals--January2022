using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        class Piece
        {
            public Piece(string name,string composer, string key)
            {
                Piecename = name;
                Composer = composer;
                Key = key;
            }
            public string Piecename { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                Piece newPiece = new Piece(piece, composer, key);
                pieces.Add(newPiece);
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = arg[0];
                if (action == "Add")
                {
                    string name = arg[1];
                    string composer = arg[2];
                    string key = arg[3];

                    if (!pieces.Any(x => x.Piecename == name))
                    {
                        Piece newPiece = new Piece(name, composer, key);
                        pieces.Add(newPiece);
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
                    Piece search = pieces.FirstOrDefault(x => x.Piecename == name);
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
                    // •	"ChangeKey|{piece}|{new key}":
                    string name = arg[1];
                    string newKey = arg[2];
                    Piece search = pieces.FirstOrDefault(x => x.Piecename == name);
                    if (search == null)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                    else
                    {
                        search.Key = newKey;
                        Console.WriteLine($"Changed the key of {name} to {newKey}!");
                    }
                }
            }
            foreach (var item in pieces)
            {
                Console.WriteLine($"{item.Piecename} -> Composer: {item.Composer}, Key: {item.Key}");

              
            }
        }
    }
}
