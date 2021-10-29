using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public Cargo(double weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public double Weight { get; set; }

        public string Type { get; set; }
    }
}
