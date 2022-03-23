using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ще получите три реда от конзолата:
            //• Брой хора, които отиват на почивка.
            //• Тип на групата(Студентски, Бизнес или Редовна).
            //• Денят от седмицата, в който групата ще остане(петък, събота или неделя).
            //Въз основа на предоставената информация изчислете колко ще плати групата за цялата ваканция.
            //Цената за един човек е както следва:
            //            петък   събота     неделя
            //Ученици     8.45      9.80     10.46
            //Бизнес     10.90     15.60       16
            //Редовни       15        20       22,50
            //Има и отстъпки въз основа на някои условия:
            //• За студенти, ако групата е 30 или повече души, трябва да намалите общата цена с 15 %
            //• За бизнес, ако групата е от 100 или повече души, 10 от хората остават безплатно.
            //• За Regular, ако групата е между 10 и 20 човека(и двете включително), намалете общата цена с 5 %
            //Забележка: Трябва да намалите цените в ТОЧНИЯ ред!
            //Като изход отпечатайте крайната цена, която групата ще плати във формат:
            //„Обща цена: { price}“
            //Цената трябва да бъде форматирана до втория десетичен знак.
            int numPeople = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (day == "Friday")
            {
                switch (people)
                {
                    case "Students":
                        price = numPeople * 8.45;
                        if (numPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        break;
                    case "Business":
                        if (numPeople >= 100)
                        {
                            price = (numPeople - 10) * 10.90;
                        }
                        else
                        {
                            price = numPeople * 10.90;
                        }
                        break;
                    case "Regular":
                        price = numPeople * 15;
                        if (numPeople >= 10 && numPeople <= 20)
                        {
                            price *= 0.95;
                        }
                        break;
                }
            }
            else if (day == "Saturday")
            {
                switch (people)
                {
                    case "Students":
                        price = numPeople * 9.80;
                        if (numPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        break;
                    case "Business":
                        if (numPeople >= 100)
                        {
                            price = (numPeople - 10) * 15.60;
                        }
                        else
                        {
                            price = numPeople * 15.60;
                        }
                        break;
                    case "Regular":
                        price = numPeople * 20;
                        if (numPeople >= 10 && numPeople <= 20)
                        {
                            price *= 0.95;
                        }
                        break;
                }
            }
            else if (day == "Sunday")
            {
                switch (people)
                {
                    case "Students":
                        price = numPeople * 10.46;
                        if (numPeople >= 30)
                        {
                            price *= 0.85;
                        }
                        break;
                    case "Business":
                        if (numPeople >= 100)
                        {
                            price = (numPeople - 10) * 16;
                        }
                        else
                        {
                            price = numPeople * 16;
                        }
                        break;
                    case "Regular":
                        price = numPeople * 22.50;
                        if (numPeople >= 10 && numPeople <= 20)
                        {
                            price *= 0.95;
                        }
                        break;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
