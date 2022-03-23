using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double budjet = double.Parse(Console.ReadLine());
                int numStudents = int.Parse(Console.ReadLine());
                double priceSword = double.Parse(Console.ReadLine());
                double priceRobe = double.Parse(Console.ReadLine());
                double priceBelt = double.Parse(Console.ReadLine());

                double sum = priceSword * Math.Ceiling (numStudents * 1.1) + (numStudents * priceRobe) + priceBelt * (numStudents - (numStudents / 6));
                double left = budjet - sum;
                double need = sum - budjet;
                if (budjet >= sum)
                {
                    Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
                }
                else
                {
                    Console.WriteLine($"John will need {need:f2}lv more.");
                }
            }
        }
    }


