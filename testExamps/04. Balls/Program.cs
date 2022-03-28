using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            //В кутия имаме неопределен брой топки с различни цветове, които ни носят различен брой точки.
            //Задачата ни е да извадим Х бр.топки, които ще бъдат въведени от конзолата, като се има в предвид,
            //че всеки различен цвят влияе на точките ни по следния начин:
            //•	Ако топката е “red” точките ни се повишават с 5.
            //•	Ако топката е “orange” точките ни се повишават с 10.
            //•	Ако топката е “yellow” точките ни се повишават с 15.
            //•	Ако топката е “white” точките ни се повишават с 20.
            //•	Ако топката е “black” точките ни се делят на 2, като закръгляме към по-малкото цяло число.
            //Ако топката е с какъвто и да е цвят, различен от по - горните, точките не се манипулират и програмата продължава да работи.
            //  Вход:
            //1.От конзолата се чете 1 цяло число N, което е броят на топките в диапазон(0 - 1000).
            //2.След това се четат N на брой цветове.
            //Изход:
            //Отпечатват се следните редове:
            //“Total points: { всичките събрани точки}”
            //“Points from red balls { броят червени топки}”
            //“Points from orange balls { броят оранжеви топки}”
            //“Points from yellow balls { броят жълти топки}”
            //“Points from white balls { броят бели топки}”
            //“Other colors picked: { броят на избраните топки извън зададените цветове}”
            //“Divides from black balls: { броят на пътите, в които точките са били разделяни на 2}”
            int num = int.Parse(Console.ReadLine());
            double points = 0;
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterBlack = 0;
            int counterOther = 0;
            for (int i  = 1; i  <= num; i ++)
            {
                string input = Console.ReadLine();
                if (input == "red")
                {
                    counterRed++;
                    points += 5;
                }
                else if (input=="orange")
                {
                    counterOrange++;
                    points += 10;
                }
                else if (input == "yellow")
                {
                    counterYellow++;
                    points += 15;
                }
                else if (input=="white")
                {
                    counterWhite++;
                    points += 20;
                }
                else if (input == "black")
                {
                    counterBlack++;
                    points = Math.Floor(points / 2);
                }
                else
                {
                    counterOther++;
                    points += 0;
                }
                
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {counterRed}");//“Points from red balls { броят червени топки}”
            Console.WriteLine($"Points from orange balls: {counterOrange}");//“Points from orange balls { броят оранжеви топки}”
            Console.WriteLine($"Points from yellow balls: {counterYellow}");//“Points from yellow balls { броят жълти топки}”
            Console.WriteLine($"Points from white balls: {counterWhite}");//“Points from white balls { броят бели топки}”
            Console.WriteLine($"Other colors picked: {counterOther}");//“Other colors picked: { броят на избраните топки извън зададените цветове}”
            Console.WriteLine($"Divides from black balls: {counterBlack}");//“Divides from black balls: { броят на пътите, в които точките са били разделяни на 2}”

        }
    }
}
