using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    class Parking
    {
        private readonly List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Car car)
        {
            if (Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            return data.Remove(data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model));
        }

        public Car GetLatestCar()
        {
            return data.OrderByDescending(x => x.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            return data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            for (int i = 0; i < data.Count; i++)
            {
                sb.AppendLine($"{data[i]}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
