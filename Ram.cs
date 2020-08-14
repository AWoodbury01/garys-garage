using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class Ram : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank () {  }

        public override void Drive(){
            Console.WriteLine("Vrrrrrrrooom");
        }

        public override void Turn(){
            Console.WriteLine("The vehicle slowly turns right");
        }
    }
}
