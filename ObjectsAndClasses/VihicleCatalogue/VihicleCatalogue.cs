using System;
using System.Linq;
using System.Collections.Generic;
namespace VihicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carCatalog = new List<Car>();
            List<Truck> truckCatalog = new List<Truck>();

            while (true)
            {
                var input = Console.ReadLine().Split("/").ToList();

                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    int horsePower = int.Parse(input[3]);

                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    carCatalog.Add(car);
                }
                else if (input[0] == "Truck")
                {
                    string brand = input[1];
                    string model = input[2];
                    int weight = int.Parse(input[3]);

                    Truck truck = new Truck();
                    truck.Model = model;
                    truck.Brand = brand;
                    truck.Weigh = weight;

                    truckCatalog.Add(truck);
                }
            }

            if (carCatalog.Count > 0 && truckCatalog.Count > 0)
            {
                List<Car> orderedCars = carCatalog.OrderBy(n => n.Brand).ToList();
                List<Truck> orderedTrucks = truckCatalog.OrderBy(n => n.Brand).ToList();

                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                Console.WriteLine("Trucks:");
                foreach (Truck truck in truckCatalog)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigh}kg");
                }
            }
            else if (carCatalog.Count > 0 && truckCatalog.Count==0)
            {
                List<Car> orderedCars = carCatalog.OrderBy(n => n.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            else if(carCatalog.Count == 0 && truckCatalog.Count > 0)
            {
                List<Truck> orderedTrucks = truckCatalog.OrderBy(n => n.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in truckCatalog)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigh}kg");
                }
            }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weigh { get; set; }

        }
        class Car
        {

            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

        }

    }
}
