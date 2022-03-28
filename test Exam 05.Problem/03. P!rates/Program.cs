using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Pirates
    {
        public Pirates(string city, int people, int gold)
        {
            City = city;
            People = people;
            Gold = gold;
        }
        public string City { get; set; }
        public int People { get; set; }
        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Докато не бъде дадена командата "Sail", вие ще получавате:
            //• Вие и вашият екипаж сте насочили към градовете, с тяхното население и злато, разделени с "||".
            //• Ако получите град, който вече е получен, трябва да увеличите населението и златото с дадените стойности.
            //След командата "Sail", ще започнете да получавате редове с текст, представящи събития, докато не бъде дадена командата "End".
            //Събитията ще бъдат в следния формат:
            //• „Plunder => { town}=>{ people}=>{ gold}“
            //o Успешно атакувахте и ограбихте града, убивайки дадения брой хора и откраднахте съответното количество злато.
            //o За всеки град, който атакувате, отпечатайте това съобщение: "{town} ограбен! {gold} злато откраднато, {people} граждани убити."
            //o Ако някоя от тези две стойности(население или злато) достигне нула, градът се разпуска.
            // Трябва да го премахнете от колекцията си от целеви градове и да отпечатате следното съобщение: "{town} е изтрит от картата!"
            //o Няма да има случай на получаване на повече хора или злато, отколкото има в града.
            //• „Prosper => { town}=>{ gold}“
            //o Имаше драматичен икономически растеж в дадения град, увеличавайки съкровищницата му с даденото количество злато.
            //o Количеството злато може да бъде отрицателно число, така че бъдете внимателни.Ако е дадено отрицателно количество злато, отпечатайте: "Добавеното злато не може да бъде отрицателно число!" и игнорирайте командата.
            //o Ако даденото злато е валидна сума, увеличете златните резерви на града със съответната сума и отпечатайте следното съобщение:
            //„{ gold added} злато е добавено към съкровищницата на града. { town} вече има { total gold} злато.“
            //Вход
            //Изход
            //• След като получите командата „Край“, ако има съществуващи населени места във вашия списък с цели, трябва да отпечатате всички в следния формат:
            //„Ахей, капитане! Има { count} богати селища, в които да отидете:
            //{ town1} -> Население: { people}  граждани, Злато: { gold} кг
            //{ town2} -> Население: { people} граждани, злато: { gold}кг
            // town…n} -> Население: { people} граждани, злато: { gold}kg"
            //• Ако не са останали селища за разграбване, отпечатайте:
            //"Ахей, капитане! Всички цели са ограбени и унищожени!"
          List<Pirates> pirates =new List<Pirates>();
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arg = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = arg[0];   
                int people = int.Parse(arg[1]);
                int gold = int.Parse(arg[2]);
                if (!pirates.Any(x => x.City == city))
                {
                    Pirates newPirates = new Pirates(city, people, gold);
                    pirates.Add(newPirates);
                    continue;
                }
               Pirates searchPirates = pirates.FirstOrDefault(x => x.City==city);
                searchPirates.People += people;
                searchPirates.Gold += gold;
                  
            }
            string command;
            while ((command=Console.ReadLine()) != "End")
            {
                string[] arg = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = arg[0];
                string city = arg[1];

                if (action== "Plunder")
                {
                int people = int.Parse(arg[2]);
                int gold = int.Parse(arg[3]);
                    Pirates searchPirates = pirates.FirstOrDefault(x => x.City == city);
                    searchPirates.People -= people;
                    searchPirates.Gold -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (searchPirates.People <= 0 || searchPirates.Gold <= 0)
                    {
                        pirates.Remove(searchPirates);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (action== "Prosper")
                {
                    int gold = int.Parse(arg[2]);
                    Pirates searchPirates = pirates.FirstOrDefault(x => x.City == city);
                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else 
                    {
                        searchPirates.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {searchPirates.Gold} gold.");
                    }
                }
            }
            if (pirates.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirates.Count} wealthy settlements to go to:");
                foreach (var item in pirates)
                {
                    Console.WriteLine($"{item.City} -> Population: {item.People} citizens, Gold: {item.Gold} kg");
                }
               
            }
        }
    }
}
