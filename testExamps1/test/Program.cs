using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проследява представянето на вашия отбор на благотворителен коледен турнир.
            //Всеки ден получавате имена на игри до команда "Finish".
            //Със спечелването на всяка една игра печелите по 20лв.за благотворителност.
            //Трябва да изчислите колко пари сте спечелили на края на деня.
            //Ако имате повече спечелени игри, отколкото загубени – вие сте победители този ден и увеличавате парите от него с 10 %.
            //При приключване на турнира ако през повечето дни сте били победители печелите турнира и увеличавате всичките спечелени пари с 20 %.
            //Никога няма да имате равен брой спечелени и загубени игри.
            //Вход
            //Първоначално от конзолата се прочита броя дни на турнира – цяло число в интервала[1… 20]
            //До получаване на командата "Finish" се чете:
            //•	Спорт  – текст
            //За всеки спорт се прочита:
            //o Резултат  – текст с възможности: "win" или "lose"
            //Изход
            //Накрая се отпечатва един ред:
            //•	Ако сте спечелили турнира:
            //     	"You won the tournament! Total raised money: {спечелените пари}"
            //•	Ако сте загубили на турнира:
            //            "You lost the tournament! Total raised money: {спечелените пари}"
            //Парите да бъдат форматирани до втората цифра след десетичния знак
            int day = int.Parse(Console.ReadLine());
            double money = 0;
            double moneyDay = 0;
            int ollCounterWin = 0;
            int ollCounterLost = 0;
            for (int i = 1; i <= day; i++)
            {
                string nameGames = Console.ReadLine();
                int counterWin = 0;
                int counterLost = 0;
                while (nameGames != "Finish")
                {
                    string rezult = Console.ReadLine();
                    if (rezult == "win")
                    {
                        money += 20;
                        counterWin++;
                        ollCounterWin++;
                    }
                    else
                    {
                        counterLost++;
                        ollCounterLost++;
                    }





                    nameGames = Console.ReadLine();

                    if (nameGames == "Finish")
                    {
                        if (counterWin > counterLost)
                            money += money * 0.10;
                        moneyDay += money;
                        money = 0;
                    }

                }
            }
                    if (ollCounterWin > ollCounterLost)
                    {
                        moneyDay  += moneyDay * 0.2;
                        Console.WriteLine($"You won the tournament! Total raised money: {moneyDay:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"You lost the tournament! Total raised money: {moneyDay:f2}");
                    }
               
           

        }
    }
}
