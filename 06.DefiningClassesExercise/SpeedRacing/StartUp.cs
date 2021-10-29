using System;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuelAmount = decimal.Parse(tokens[1]);
                var fuelCost = decimal.Parse(tokens[2]);
                cars[i] = new Car(model, fuelAmount, fuelCost);

                
            }

            while (true)
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (input == "End")
                {
                    break;
                }

                var model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);

                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.TravelledDistance}");
            }
        }
    }
}
