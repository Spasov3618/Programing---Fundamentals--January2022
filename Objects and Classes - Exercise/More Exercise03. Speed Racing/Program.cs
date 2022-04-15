using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercise03._Speed_Racing
{
    class Car
    {
        public Car(string model,double fuel,double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            Kilometers = 0;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Consumption { get; set; }
        public double Kilometers { get; set; }
       }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да приложите програма, която следи колите и тяхното гориво и поддържа методи за придвижване на автомобилите. Определете клас Автомобил, който следи модела на автомобила, количеството гориво, разхода на гориво на километър и изминатото разстояние.Моделът на колата е уникален - никога няма да има 2 коли с един и същ модел.
            // На първия ред на входа ще получите число N – броят на колите, които трябва да проследите. На всеки от следващите N реда ще получавате информация за автомобили в следния формат "<Model> <FuelAmount> <FuelConsumptionFor1km>".Всички автомобили започват от 0 километра изминат.
            //След N реда, докато не бъде получена командата "Край", ще получавате команди в следния формат "Шофиране <CarModel> <amountOfKm>".Внедрете метод в класа Car, за да изчислите дали автомобилът може да се движи на това разстояние или не.Ако може, количеството гориво на автомобила трябва да бъде намалено с количеството използвано гориво и изминатото разстояние да се увеличи с броя на изминатите километри. В противен случай автомобилът не трябва да се движи(количеството му гориво и изминатото разстояние трябва да останат същите) и трябва да отпечатате на конзолата "Недостатъчно гориво за шофирането".След получаване на командата "Край", отпечатайте всяка кола, текущото й количество гориво и изминатото разстояние във формат "<Model> <fuelAmount> <distanceTraveled>".Отпечатайте количеството гориво, закръглено до две цифри след десетичния разделител. 
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);
                Car newCar = new Car(model, fuel, consumption);
                cars.Add(newCar);
            }
            string drive;
            while ((drive=Console.ReadLine()) != "End")
            {
                string[] arg = drive.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = arg[1];
                double km = double.Parse(arg[2]);
              
               Car searchCar = cars.FirstOrDefault(x => x.Model == model);
                if (searchCar!= null)
                {

                double needFuel = km * searchCar.Consumption;
                if (needFuel<= searchCar.Fuel)
                {
                    searchCar.Fuel -= needFuel;
                    searchCar.Kilometers += km;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive") ;
                }
                }
            }
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.Fuel:f2} {item.Kilometers}");
            }
        }
    }
}
