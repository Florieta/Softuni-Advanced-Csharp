using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        private readonly List<Car> Participants;

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }
        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void Add(Car car)
        {
            bool isExisted = false;
            foreach (Car participant in Participants)
            {
                if (participant.LicensePlate == car.LicensePlate)
                {
                    isExisted = true;
                }
            }

            if (!isExisted)
            {
                if (Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
                {
                    Participants.Add(car);
                }
            }
        }
        public bool Remove(string licensePlate)
        {
            return Participants.Remove(Participants.FirstOrDefault(x => x.LicensePlate == licensePlate));
        }
        public Car FindParticipant(string licensePlate)
        {
            return Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }

        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            for (int i = 0; i < Participants.Count; i++)
            {
                sb.AppendLine($"{Participants[i]}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
