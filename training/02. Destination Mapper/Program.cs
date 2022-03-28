using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ще ви бъде даден низ, представляващ някои места на картата.Трябва да филтрирате само валидните.Валидно местоположение е:
            //• Заобиколен от "=" или "/" от двете страни(първият и последният символ трябва да съвпадат)
            //• След първото "=" или "/" трябва да има само букви(първите трябва да са главни, другите букви могат да бъдат главни или малки)
            //• Буквите трябва да са поне 3
            //Пример: В низа "=Hawai=/Cyprus/=Invalid/invalid==i5valid=/I5valid/=i=" са валидни само първите две местоположения.
            //След като съпоставите всички валидни местоположения, трябва да изчислите точки за пътуване.Те се изчисляват чрез сумиране на дължините на всички валидни дестинации, които сте намерили на картата.
            //Накрая на първия ред отпечатайте: "Дестинации: {дестинации, присъединени от ', '}".
            //На втория ред отпечатайте „Travel Points: { travel_points}“.
            //Вход / Ограничения
            //• Ще получите низ, представящ местоположенията на картата
            //• JavaScript: ще получите един параметър: низ
            //Изход
            //• Отпечатайте съобщенията, описани по - горе
            string input = Console.ReadLine();
            List<string> output = new List<string>();
            int sum = 0;
            string pattern = @"(=|\/)(?<destination>[A-Z][A-z]{2,})\1";
            MatchCollection matchCollection = Regex.Matches(input, pattern);
            if (Regex.IsMatch(input,pattern))
            {
                foreach (Match item in matchCollection)
                {
                    sum += item.Groups["destination"].Length;
                    string destination = item.Groups["destination"].Value;
                    output.Add(destination);
                }
            }
            
            Console.WriteLine($"Destinations: {string.Join(", ",output)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
