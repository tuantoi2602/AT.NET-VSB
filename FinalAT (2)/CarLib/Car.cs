using System;
using System.Collections.Generic;
using System.Text;

namespace CarLib
{
    class Car
    {
        //Property
        public double Distance { get; set; }

        //Field
        public int Time;


        public double AverageSpeed()
        {
            return this.Distance / this.Time;
        }

        public double TravelingTime(double currentDistance)
        {
            return AverageSpeed() * currentDistance;
        }  
    }
}
