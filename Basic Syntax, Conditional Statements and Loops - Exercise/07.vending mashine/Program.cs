using System;

namespace _07.vending_mashine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която натрупва монети. Докато не бъде дадена командата "Старт", ще получавате монети, като трябва да се натрупват само валидните.Валидни монети са:
            //• 0,1, 0,2, 0,5, 1 и 2
            //Ако е поставена невалидна монета, отпечатайте „Cannot accept { money}“ и продължете към следващия ред.
            //На следващите редове, докато не бъде дадена командата "Край", ще започнете да получавате продукти, които клиент иска да купи.Вендинг машината има само:
            //• "Ядки" с цена 2.0
            //• „Вода” с цена 0,7
            //• "Чипсове" с цена 1,5
            //• "Сода" с цена 0,8
            //• "Кока-Кола" с цена 1.0
            //Ако клиентът се опита да закупи несъществуващ продукт, отпечатайте „Невалиден продукт“.
            //Когато клиентът има достатъчно пари, за да закупи избрания продукт, отпечатайте „Закупено { product name}“, в противен случай отпечатайте „Съжаляваме, няма достатъчно пари“ и продължете към следващия ред.
            //Когато се даде командата „Край“, отпечатайте напомнящия баланс, форматиран до втората десетична запетая: „Промяна: { money left}“. 
            string moneu = Console.ReadLine();
            double sum = 0;
            while (moneu != "Start")
            {
                if (moneu!="0.1" && moneu!="0.2" && moneu!= "0.5" && moneu!="1" && moneu!= "2")
                {
                    Console.WriteLine($"Cannot accept {moneu}");

                }
                else
                {
                    sum += double.Parse(moneu);
                }
                moneu = Console.ReadLine();
            }
            if (moneu == "Start")
            {
                string product = Console.ReadLine();
                while (product!= "End")
                {
                    switch (product)
                    {
                        case "Nuts":                 //"Nuts" with a price of 2.0
                            if (sum>=2)
                            {
                                Console.WriteLine($"Purchased nuts");
                                sum -= 2;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":             //•	"Water" with a price of 0.7
                            if (sum >= 0.7)
                            {
                                Console.WriteLine($"Purchased water");
                                sum -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":                        //•	"Crisps" with a price of 1.5
                            if (sum >= 1.5)
                            {
                                Console.WriteLine($"Purchased crisps");
                                sum -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":                        //•	"Soda" with a price of 0.8
                            if (sum >= 0.8)
                            {
                                Console.WriteLine($"Purchased soda");
                                sum -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sum >= 1)
                            {
                                Console.WriteLine($"Purchased coke");
                                sum -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;//•	"Coke" with a price of 1.0

                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                    product = Console.ReadLine();
                }
                if (product == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                }
            }
        }
    }
}
