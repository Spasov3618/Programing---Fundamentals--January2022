using System;
using System.Linq;
using System.Collections.Generic;
namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте програма, която:
            //• Чете въведени цели числа и ги добавя към стека
            //• Чете команда, докато се получи "край".
            //• Отпечатва сумата от останалите елементи на стека
            //Вход
            //• На първия ред ще получите масив от цели числа
            //• На следващите редове, докато не бъде дадена командата „край“, ще получавате команди – една команда и едно или две числа след командата, в зависимост от това каква команда ви е дадена
            //• Ако командата е "добави", винаги ще получавате точно две числа след командата, която трябва да добавите към стека
            //• Ако командата е "премахване", винаги ще получавате точно едно число след командата, което представлява броя на числата, които трябва да премахнете от стека.Ако няма достатъчно елементи, пропуснете командата.
            //Изход
            //• Когато се получи командата "end", трябва да отпечатате сумата от останалите елементи в стека
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string [] arg = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string move = arg[0];
                if (move == "add")
                {
                    int numOne = int.Parse(arg[1]);
                    int numTwo = int.Parse(arg[2]); 
                  input =  input.Append(numOne).ToArray();
                  input =  input.Append(numTwo).ToArray();

                }
                else if (move== "remove")
                {
                    int num =int.Parse(arg[1]);
                    int n = input.Length - num;
                    if (n<= input.Length && n>0)
                    {
                   input= input.Take(n).ToArray();

                    }
                }
            }
            int sum = input.Sum(x => x);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
