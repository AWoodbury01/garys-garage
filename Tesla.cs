using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class Tesla : Vehicle
    {  // Propellor light aircraft
        public double BatteryKWh { get; set; }
        public void ChargeBattery () {  }
        public override void Drive(){
            Console.WriteLine("zoooooom");
        }
        public override void Turn(){
            Console.WriteLine("The vehicle squeals around a right turn");
        }

    }
}
