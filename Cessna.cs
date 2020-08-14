using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank () {  }

        public override void Drive(){
            Console.WriteLine("swooosh");
        }

        public override void Turn(){
            Console.WriteLine("The vehicle banks right")
        }
    }
}
