using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Cars
    {
        //Brand, Model, and Horse Power
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Truck
    {
        //Brand, Model, and Weight
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Cars> Cars { get; set;  }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            List<Truck> truck = new List<Truck>();
            string command;
            while ((command=Console.ReadLine()) != "end")
            {
                string[] input = command.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                string brand =input[1];
                string model = input[2];    
                string horsePower = input[3];
                if (name  == "Car")
                {
                    Cars car = new Cars();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    cars.Add(car);
                    
                }
                if (name == "Truck")
                {
                    Truck trucks = new Truck();
                    trucks.Brand = brand;
                    trucks.Model = model;
                    trucks.Weight = horsePower;
                    truck.Add(trucks);
                }
            }
           List<Truck> formatingTruck = truck.OrderBy (x => x.Brand).ToList();
           List<Cars> formatingCars = cars.OrderBy (x => x.Brand).ToList();
            if (cars.Count>0)
            {
                Console.WriteLine("Cars:");  
                foreach (Cars item in formatingCars)
                {
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");

                }
            }
            if (truck.Count>0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck item in formatingTruck)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }

        }
    }
}
