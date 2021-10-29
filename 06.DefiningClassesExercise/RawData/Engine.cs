using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(double speed, double power)
        {
            Speed = speed;
            Power = power;
        }

        public double Speed { get; set; }

        public double Power { get; set; }
    }
}
