using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {

        public Car(string model, decimal fuel, decimal consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public decimal Fuel { get; set; }

        public decimal Consumption { get; set; }

        public decimal TravelledDistance { get; set; }

        public void Drive(decimal distance)
        {
            decimal fuelNeeded = distance * Consumption;
            if (Fuel >= fuelNeeded)
            {
                Fuel -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
