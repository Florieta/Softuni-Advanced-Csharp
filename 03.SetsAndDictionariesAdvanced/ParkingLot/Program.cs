using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (command != "END")
            {
                string[] data = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = data[0];
                string regNumber = data[1];
                if (direction == "IN")
                {
                    cars.Add(regNumber);
                }
                else
                {
                    cars.Remove(regNumber);
                }
                command = Console.ReadLine();

            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
            

            
        }
    }
}
