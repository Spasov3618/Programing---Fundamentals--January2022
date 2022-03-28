using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int day = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double totalDog = 0;
            double totalCat = 0;
            double biscuits = 0;
            double dogEndCat = 0;
            for (int i = 1; i <= day; i++)
            {
               int foodDog = int.Parse(Console.ReadLine());
                int foodCat = int.Parse(Console.ReadLine());
               
               
                    totalDog += foodDog;
                    totalCat += foodCat;
                    dogEndCat = foodDog + foodCat;
                
                if (i % 3 ==0)
                {
                    biscuits += Math.Round ( dogEndCat * 0.10);
                }
            }
            double foodDogEndCat = totalDog + totalCat;
            double percentFood = 1.0 * foodDogEndCat / totalFood * 100;
            double percentDog = 1.0 * totalDog / foodDogEndCat * 100;
            double percentCat = 1.0 * totalCat / foodDogEndCat * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{percentFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");
        }
    }
}
