using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07._Hideout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вие сте детектив от Скотланд Ярд и трябва да намерите скривалището на много опасна група престъпници. Ще получите карта под формата на низ и след това ще получите улики от разузнаването.
            //На следващото неизвестно количество линии ще получите масиви, съдържащи два елемента: 
            //Първият елемент ще бъде знакът, който бележи скривалището.
            //Вторият елемент ще бъде минималният брой знаци, които трябва да търсите.  
            //Масивът ще бъде във формат: "{търсенCharacter} {minimumCount}".
            //Ако не можете да намерите скривалище(продължете да четете следващите два реда.
            //Ако намерите скривалище (спрете програмата и отпечатайте индекса, където скривалището започва и дължината на скривалището.
            //Въвеждане
            //На първия ред ще получите картата, която ще съдържа случайни струни.
            //При следващото неизвестно количество редове ще получите масиви
            //Първият елемент е търсеният знак
            //Вторият елемент е минималният брой, който трябва да бъде претърсен
            //Изход
            //Ако намерите скривалището, отпечатайте:
            //"Скривалище, намерено при индекс {indexOfTheFirstChar} и то е с размер {lengthOfTheFoundString}!"
            string input = Console.ReadLine();
            while (true)
            {
                string[] arg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string sing = Regex.Escape(arg[0]);
               
                int singLengh = int.Parse(arg[1]);
               // int index = input.IndexOf(sing, singLengh);
                string pattern = $@"[{sing}]+";

                foreach (Match item in Regex.Matches(input, pattern))
                {
                    if (item.Length >= singLengh)
                    {
                        Console.WriteLine($"Hideout found at index {item.Index} and it is with size {item.Length}!");

                        return;
                    }
                }
            }
        }

        
    }
}
