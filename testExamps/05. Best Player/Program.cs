using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пепи иска да напишете програма, чрез която да разбере кой е най - добрият играч от световното първенство.
            //  Информацията, която получавате ще бъде играч и колко гола е отбелязал.
            // От вас се иска да отпечатате кой е играчът с най - много голове и дали е направил хет-трик.Хет -
            // трик е, когато футболистът е вкарал 3 или повече гола.Ако футболистът е вкарал 10 или повече гола,
            // програмата трябва да спре.
            //Вход:
            // От конзолата се четат по два реда до въвеждане на команда "END":

            //•	Име на играч – текст
            //•	Брой вкарани голове  – цяло положително число в интервала[1 … 10000]


            //Изход:
            //            На конзолата да се отпечатат 2 реда:
            //•	На първия ред:
            //            "{име на играч} is the best player!"
            //•	На втория ред:
            //            o Ако най - добрият футболист е направил хеттрик:
            //                   "He has scored {брой голове} goals and made a hat-trick !!!"
            //o Ако най - добрият футболист не е направил хеттрик:
            //            "He has scored {брой голове} goals."
            string namePlayer = Console.ReadLine();
            int veryGools = 0;
            int hatTrik = 0;
            
            string bestPlayer = "";
            while (namePlayer != "END")
            {
            int numGools = int.Parse(Console.ReadLine());
                if (veryGools < numGools)
                {
                    veryGools = numGools;
                    bestPlayer = namePlayer;
                }
                if (numGools >=3)
                {
                    hatTrik = numGools;
                    bestPlayer = namePlayer;
                }
                if (numGools >=10)
                {
                    break;
                }
                namePlayer = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (veryGools >=3)
            {
                Console.WriteLine($"He has scored {veryGools} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {veryGools} goals.");    
            }

        }
    }
}
