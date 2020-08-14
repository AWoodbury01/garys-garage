using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class Zero : Vehicle 
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery () {  }

        public override void Drive(){
            Console.WriteLine("zeeeeeeee");
        }

        public override void Turn(){
            Console.WriteLine("The vehicle banks right");
        }
    }
}

