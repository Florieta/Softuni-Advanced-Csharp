

using System;
using System.Text;

namespace CarConstructors
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public string Make { get; private set; } = "VW";


        public string Model { get; private set; } = "Golf";

        public int Year { get; private set; } = 2025;


        public double FuelQuantity { get; private set; } = 200;


        public double FuelConsumption { get; private set; } = 10;


        public void Drive(double distance)

        {

            bool canContinue = (this.FuelQuantity - (distance * this.FuelConsumption)) >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {this.Make}");

            sb.AppendLine($"Model: {this.Model}");

            sb.AppendLine($"Year: {this.Year}");

            sb.Append($"Fuel: {this.FuelQuantity:F2}L");

            return sb.ToString();
        }
    }
}
