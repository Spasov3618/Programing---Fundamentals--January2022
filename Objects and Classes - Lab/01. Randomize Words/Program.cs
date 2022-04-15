using System;
using System.Linq;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ще ви бъде даден низ, който ще съдържа думи, разделени с един интервал.Подредете на случаен принцип и отпечатайте всяка дума на нов ред.
            //• Разделете входния низ с(интервал) и създайте масив от думи.
            //• Създаване на генератор на произволни числа – обект rnd от тип Random.
            //• При обмен на for-loop всяко число на позиции 0, 1, ... думи.Дължина - 1 с число на произволна позиция.За генериране на произволно число в диапазона използвайте rnd.Next(minValue, maxValue).Имайте предвид, че по дефиниция minValue е включващо, но maxValue е изключително.
            //• Отпечатайте всяка дума от масива на нов ред.
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();
            for (int i = 0; i < input.Length; i++)

            {
                int randomIndex = random.Next(0, input.Length);
                string curent = input[i];
               input[i] = input[randomIndex];
                input[randomIndex] = curent;
            }
                foreach (string item in input)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
