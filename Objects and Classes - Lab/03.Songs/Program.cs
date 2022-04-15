using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Song
    {
        public Song (string typeList, string name,string time)
        {
        TypeList = typeList;
        Name = name;
        Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дефинирайте клас, наречен Song, който ще съдържа следната информация за някои песни:
            //• Списък с типове
            //• Име
            //• Време
            //Вход / Ограничения
            //• На първия ред ще получите броя на песните -N.
            //• На следващите N реда ще получавате данни в следния формат: „{ typeList}_{ name}_{ time}“
            //• На последния ред ще получите Type List или "all".
            //Изход
            //Ако получите Type List като вход на последния ред, отпечатайте само имената на песните, които са от този Type List.Ако получите командата "всички", разпечатайте имената на всички песни.
            int numOfSong = int.Parse(Console.ReadLine());
            List<Song> song = new List<Song>();
            for (int i = 0; i < numOfSong; i++)
            {
                string[] input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                string time = input[2];
                Song songs = new Song(type, name, time);
                song.Add(songs);    
            }
            string typeList = Console.ReadLine();
            if (typeList=="all")
            {
            List<Song> filtered = song.OrderBy(x => x.Name == typeList).ToList();
                foreach (Song item in filtered)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
               List<Song> filtered = song.OrderBy(x => x.TypeList == typeList).ToList();
                foreach (Song item in filtered) 
                {
                    if (item.TypeList == typeList)
                    {
                            Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}
