using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ще ви бъде дадено цяло число, напишете програма, която проверява дали даденото цяло число се дели на 2, или 3, или 6, или 7, или 10 без напомняне. Винаги трябва да вземете по - голямото деление:
            //• Ако числото се дели и на 2, и на 3, и на 6, трябва да отпечатате само деленето само на 6.
            //• Ако числото се дели на 2 и 10, трябва да отпечатате делението на 10.
            //Ако числото не се дели на нито едно от дадените числа, отпечатайте „Не се дели“. В противен случай отпечатайте "Числото се дели на {число}".
            int number = int.Parse(Console.ReadLine());
            if (number%10==0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number%7==0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number%6==0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number%3==0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number%2==0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else 
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
