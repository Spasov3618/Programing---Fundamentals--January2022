using System;
using System.Linq;
using System.Collections.Generic;


namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма за нулиране на парола, която изпълнява поредица от команди върху предварително дефиниран низ. Първо ще получите низ, а след това, докато не бъде дадена командата "Готово", ще получавате низове с команди, разделени с един интервал. Командите ще бъдат следните:
            //• „TakeOdd“
            //o Взема само символите с нечетни индекси и ги конкатенира, за да получи новата необработена парола и след това я отпечатва.
            //• „Изрежете { index} { length}“
            //o Получава подниз с дадена дължина, започвайки от даден индекс от паролата и премахва първото му появяване, след което отпечатва паролата на конзолата.
            //o Даденият индекс и дължината винаги ще бъдат валидни.
            //• „Заместете { substring}
            //            { substitute}“
            //o Ако необработената парола съдържа дадения подниз, заменя всички негови срещания с дадения заместващ текст и отпечатва резултата.
            //o Ако не, отпечатва „Няма нищо за замяна!“.
            //Вход
            //• Ще получавате низове, докато не бъде дадена командата "Готово".
            //Изход
            //• След като бъде получена командата "Готово", отпечатайте:
            //            o „Вашата парола е: { password}“
            //Ограничения
            //• Индексите от командата "Cut {index} {length}" винаги ще бъдат валидни. 
            string password = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine())!= "Done")
            {
                string[] arg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (arg[0] == "TakeOdd")
                {
                    for (int i = password.Length - 1; i >= 0; i--)
                    {
                        if (i % 2 == 0)
                        {

                            password = password.Remove(i, 1);
                        }
                    }
                        Console.WriteLine(password);
                }
                else if (arg[0] == "Cut")
                {
                    password = password.Remove(int.Parse(arg[1]),int.Parse(arg[2]));
                Console.WriteLine(password);
                }
                else if (arg[0] == "Substitute")
                {
                    if (password.Contains(arg[1]))
                    {
                    password = password.Replace(arg[1], arg[2]);
                    Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }

    }
} 
