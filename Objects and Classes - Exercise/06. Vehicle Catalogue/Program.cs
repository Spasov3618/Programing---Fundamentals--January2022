using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string typeOfVehicle, string model,string color, double horsePower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;  
            HorsePower = horsePower;

        }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Докато не получите командата "Край", ще получавате входни редове в следния формат:

            //"{typeOfVehicle} {model} {color} {horsepower}"

            //След като получите командата "End", ще започнете да получавате информация за някои превозни средства.
            //За всяко превозно средство разпечатайте информацията за него в следния формат:
            //"Type: {typeOfVehicle}
            //Model: { modelOfVehicle}
            //Color: { colorOfVehicle}
            //Horsepower: { horsepowerOfVehicle}

            //Когато получите командата „Close the Catalogue“, разпечатайте средните конски сили на автомобилите и средните конски сили на камионите във формат:

            //"{typeOfVehicles} have average horsepower of {averageHorsepower}."

            //Средната мощност се изчислява като сумата от конските сили на всички превозни средства от дадения тип се раздели на общия брой на всички превозни средства от този тип. Форматирайте отговора до втората цифра след десетичната запетая.
            //Ограничения
            //• Типът превозно средство винаги ще бъде или автомобил, или камион.
            //• Няма да получите един и същ модел два пъти.
            //• Получените конски сили ще бъдат цяло число в диапазона[1…1000]
            //• Ще получите най - много 50 превозни средства.
            //• Разделителят винаги ще бъде единичен празен интервал.
            List <Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            string input;
            double horsePowerCar = 0;
            double horsePowerTruck = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = info[0];
                string model = info[1];
                string color = info[2];
                double horsePower = double.Parse(info[3]);
                Vehicle newVenichle = new Vehicle(type,model, color, horsePower);
                if (type == "truck")
                {
                    trucks.Add(newVenichle);
                    horsePowerTruck += horsePower;
                }
                else if (type == "car")
                {
                    cars.Add(newVenichle);
                    horsePowerCar+=horsePower;
                }
            }
            string command;
            while ((command=Console.ReadLine()) != "Close the Catalogue")
            {
                             
               Vehicle searchModel = cars.FirstOrDefault(x=> x.Model == command);
                if (searchModel != null)
                {
                    Console.WriteLine($"Type: Car");//"Type: {typeOfVehicle}
                    Console.WriteLine($"Model: {searchModel.Model}");//Model: { modelOfVehicle}
                    Console.WriteLine($"Color: {searchModel.Color}");//Color: { colorOfVehicle}
                    Console.WriteLine($"Horsepower: {searchModel.HorsePower}");//Horsepower: { horsepowerOfVehicle}
                }
                Vehicle search = trucks.FirstOrDefault(x => x.Model == command);
                if (search != null)
                {
                    Console.WriteLine($"Type: Truck");//"Type: {typeOfVehicle}
                    Console.WriteLine($"Model: {search.Model}");//Model: { modelOfVehicle}
                    Console.WriteLine($"Color: {search.Color}");//Color: { colorOfVehicle}
                    Console.WriteLine($"Horsepower: {search.HorsePower}");//Horsepower: { horsepowerOfVehicle}
                }
            }
            if (cars.Count == 0)
            {
                horsePowerCar = 0;
            }
            else
            {

            horsePowerCar = horsePowerCar/cars.Count();
            }
            if (trucks.Count == 0)
            {
                horsePowerTruck = 0;
            }
            else
            {

            horsePowerTruck=horsePowerTruck/trucks.Count();
            }
            Console.WriteLine($"Cars have average horsepower of: {horsePowerCar:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {horsePowerTruck:f2}.");

        }
    }
}
