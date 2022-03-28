using System;
using System.Linq;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред ще ви бъде даден низ, съдържащ всичките ви спирки.Докато не получите командата "Пътуване", ще ви бъдат дадени някои команди за манипулиране на този първоначален низ. Командите могат да бъдат:
            //• „Добавяне на стоп: { index}:{ string}“:
            //o Вмъкнете дадения низ в този индекс само ако индексът е валиден
            //• „Премахване на стоп: { start_index}:{ end_index}“:
            //o Премахнете елементите на низа от началния индекс до крайния индекс(включително), ако и двата индекса са валидни
            //• „Превключване: { old_string}:{ new_string}“:
            //o Ако старият низ е в първоначалния низ, заменете го с новия(всички събития)
            //Забележка: След всяка команда отпечатайте текущото състояние на низа
            //След командата „Пътуване“ отпечатайте следното: „Готови за световно турне!Планирани спирки: { string}“
            //Вход / Ограничения
            //• JavaScript: ще получите списък с низове
            //• Индексът е валиден, ако е между първия и последния индекс на елемента(включително) в последователността.
            //Изход
            //• Отпечатайте правилните изходни съобщения в правилните случаи, както е описано в описанието на проблема
            string input = Console.ReadLine();
            string command;
            while ((command=Console.ReadLine())!= "Travel")
            {
                string[] arg = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = arg[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(arg[1]);
                    string destination = arg[2];
                    if (index>=0 && index<input.Length)
                    {
                       input= input.Insert(index, destination);
                    }
                        Console.WriteLine(input);
                }
               else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(arg[1]);
                    int endIndex = int.Parse(arg[2]);
                    if (startIndex>=0 && startIndex< input.Length && endIndex>=0 && endIndex<input.Length)
                    {
                   input = input.Remove(startIndex, endIndex - (startIndex-1));
                    }
                    Console.WriteLine(input);
                }
                else if (action == "Switch")
                {
                    string oldSwitch = arg[1];
                    string newSwitch = arg[2];
                    if (input.Contains(oldSwitch))
                    {

                   input= input.Replace(oldSwitch, newSwitch);
                    }
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
