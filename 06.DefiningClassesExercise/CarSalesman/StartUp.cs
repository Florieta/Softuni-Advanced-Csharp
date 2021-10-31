using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var info = Console.ReadLine().Split();
                engines.Add(CreateEngine(info));
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int j = 0; j < numberOfCars; j++)
            {
                var info = Console.ReadLine().Split();
                cars.Add(CreateCar(info, engines));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Car CreateCar(string[] info, List<Engine> engines)
        {
            var engine = engines.Find(e => e.Model == info[1]);
            var car = new Car(info[0], engine);
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;

                }
                else
                {
                    car.Color = info[2];
                }

                if (info.Length > 3)
                {
                    car.Color = info[3];
                }
            }
                



            return car;
        }

        public static Engine CreateEngine(string[] info)
        {
            Engine engine = new Engine(info[0], int.Parse(info[1]));
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;

                }
                else
                {
                    engine.Efficiency = info[2];
                }

                if (info.Length > 3)
                {
                    engine.Efficiency = info[3];
                }

            }

            return engine;
        }
    }
}
