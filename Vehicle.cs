using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive(){
            Console.WriteLine("Vrooooooom!");
        }
        public virtual void Turn(){
            Console.WriteLine("The vehicle carefully turns right");
        }
    }
}

