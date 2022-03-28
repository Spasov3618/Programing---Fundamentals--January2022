using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Фирмата предлага също и доставка на поръчките си срещу 60 лв.
            
            //Ако поръчката надвишава 99 броя  – върху крайната цена се начисляват допълнителни 4 % отстъпка
            //(след като се начисли цената за доставка, ако има такава).
            //При поръчка под 10 бр.на конзолата да бъде изписано "Invalid order"
                      
            //•	С доставка -"With delivery"
            //•	Без доставка -"Without delivery"
            //Изход:
            //            Извежда се едно число – стойността на поръчката, в следния формат:
            //            o   "{Обща стойност на поръчката} BGN"
            //Резултатът да се форматира до втори знак след десетичната запетая.
            int numWindows = int.Parse(Console.ReadLine());
            string kindWindows = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            if (numWindows<10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (kindWindows )
            {
                case "90X130":
                    price =  110;
                    if (numWindows >=30 && numWindows <=60)
                    {
                        price *= 0.95;

                    }
                    else if (numWindows >60)
                    {
                        price *= 0.92;
                    }
                    break;
                case "100X150":
                    price = 140;
                    if (numWindows >=40 && numWindows <=80)
                    {
                        price *= 0.94;
                    }
                    else if (numWindows >80)
                    {
                        price *= 0.9;
                    }
                    break;
                case "130X180":
                    price = 190;
                    if (numWindows >=20 && numWindows<=50)
                    {
                        price *= 0.93;
                    }
                    else if (numWindows >50)
                    {
                        price *= 0.88;
                    }
                    break;
                case "200X300":
                    price = 250;
                    if (numWindows >=25 && numWindows <=50)
                    {
                        price *= 0.91;
                    }
                    else if (numWindows>50)
                    {
                        price *= 0.86;
                    }
                    break;
            }
            totalPrice = numWindows * price;
            switch (delivery)
            {
                case "With delivery":
                    totalPrice += 60;
                    break;
                    
            }
            if (numWindows >99)
            {
                totalPrice *= 0.96;
            }
            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}
