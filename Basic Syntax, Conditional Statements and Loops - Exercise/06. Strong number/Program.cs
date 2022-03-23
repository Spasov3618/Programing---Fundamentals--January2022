using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която получава едно цяло число и изчислява дали е силно или не.Числото е силно, ако сборът от факторите на всяка цифра е равен на числото.
            //Пример: 145 е силно число, защото 1! + 4! + 5! = 145.
            //Отпечатайте "да", ако числото е силно, или "не", ако числото не е силно.
            int num = int.Parse(Console.ReadLine());
            int firstNum = num;
            int sum = 0;
            while (num > 0)
            {
                int curentNum = num % 10;
                int faktoriel = 1;
                for (int i = 1; i <= curentNum; i++)
                {
                    faktoriel *= i;
                }
                sum += faktoriel;
                num /= 10;
            }
            if (firstNum == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
