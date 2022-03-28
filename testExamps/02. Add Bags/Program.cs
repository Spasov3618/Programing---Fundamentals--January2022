using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            //25.50
            //5
            //36
            //6


            //Изход
            //Да се отпечата на конзолата сумата, която ще трябва да заплати Мими за багажите, в следния формат:
            //•	" The total price of bags is: {цената на багажите} lv. "
            //Сумата да бъде форматирана до втората цифра след десетичния знак.
            double priceBags = double.Parse(Console.ReadLine());
            double kgBags = double.Parse(Console.ReadLine());
            int dayOffTravev = int.Parse(Console.ReadLine());
            int numBags = int.Parse(Console.ReadLine());
            double price = 0;
            double totalSum = 0;
            if (kgBags <10)
            {
                price = priceBags * 0.2;
            }
            else if (kgBags >=10 && kgBags <=20)
            {
                price = priceBags * 0.5;
            }
            else
            {
                price = priceBags;
            }
            if (dayOffTravev >30)
            
            {
                price += price * 0.1;
            }
            else if (dayOffTravev >= 7 && dayOffTravev <= 30)
            {
                price += price * 0.15;
            }
            else if (dayOffTravev <7)
            {
                price += price * 0.4;
            }
            totalSum =  price * numBags;
            Console.WriteLine($" The total price of bags is: {totalSum:f2} lv. ");
        }
    }
}
//25.50
//5
//36
//6

