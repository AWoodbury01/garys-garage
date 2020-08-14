using System;
using System.Collections.Generic;


namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Zero myMotorcycle = new Zero();
            myMotorcycle.MainColor = "Red";

            Cessna myPlane = new Cessna();
            myPlane.MainColor = "White";

            Tesla myTesla = new Tesla();
            myTesla.MainColor = "Blue";

            Ram myTruck = new Ram();
            myTruck.MainColor = "Black";

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(myPlane);
            garage.Add(myTesla);
            garage.Add(myTruck);
            garage.Add(myMotorcycle);

            foreach(Vehicle myVehicle in garage){
                Console.WriteLine($"The {myVehicle.MainColor} {myVehicle} vehicle goes"); 
                myVehicle.Drive();
                
            }

        }
    }
}
