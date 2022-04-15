using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>[\d\.\d+]+)!(?<quontity>[\d]+)";
            Regex regex = new Regex(pattern);
            double sum = 0;
            //Създайте програма за изчисляване на общата цена на различните видове мебели.Ще ви бъдат дадени няколко реда за въвеждане, докато не получите реда "Покупка".За да е валиден редът, той трябва да бъде в следния формат:
            //">>{име на мебели<<{price}!{quantity}"
            //Цената може да бъде число с плаваща запетая или цяло число.Съхранявайте имената на мебелите и общата цена.В края отпечатайте всяка закупена мебел на отделен ред във формат:
            //„Закупени мебели:
            //{ 1 - во име}
            //{ 2nd name}…"
            //И на последния ред отпечатайте следното: „Общо изразходване на пари: { spend money}“, форматирано до втората десетична запетая.
            List<string> rezult = new List<string>();
            string input;
            while ((input=Console.ReadLine()) != "Purchase")
            {
               // MatchCollection info = regex.Matches(input);  
               Match match = Regex.Match(input,pattern,RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quontity = int.Parse(match.Groups["quontity"].Value);
                    rezult.Add(name);
                    sum += price * quontity;
                }
            }
            Console.WriteLine("Bought furniture: ");
            foreach (var item in rezult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
