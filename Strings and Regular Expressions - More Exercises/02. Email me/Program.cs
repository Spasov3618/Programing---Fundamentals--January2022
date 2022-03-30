using System;

namespace _02._Email_me
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Снощи Пешо получи имейла на момиче. За съжаление, той не може да си спомни дали тя си е струвала. Той има план как да реши дали трябва да съобщение на момичето и той се нуждае от вашите умения за програмиране.
            //Той ще ви даде имейла й и вашата задача е да извадите сумата от знаците след "@" от сумата на знаците преди "@".
            //Ако резултатът е равен или по-голям от 0 – той ще напише имейла й, в противен случай няма. 
            //Въвеждане
            //Ще получите единична линия с имейла на момичето.
            //Изход
            //Ако резултатът е равен или по - голям от 0 печат:
            //Обади й се!
            //В противен случай отпечатайте:
            //Тя не е тази.
            string email = Console.ReadLine();
            char sing = '@';
            int firstWord = 0;
            int secondWord = 0;
            for (int i = 0; i < email.Length; i++)
            {
                char c = email[i];
                if ( c == sing) 
                {
                    break;
                }
                else
                {
                    firstWord += email[i];
                }
            }
            for (int i = email.Length - 1; i >= 0; i--)
            {
                char c = email[i];
                if (c == sing)
                {
                    break;
                }
                else
                {
                    secondWord += email[i];
                }
            }
            int total = firstWord- secondWord;
            if (total>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
