using Klasser;
using System.Collections.Generic;
using System;
using ExtensionMethods;

namespace ArvOchAbstraktion
{
    public class Verkstad : IVerkstad
    {
        public List <Vehicle> Vehicles { get; set; }

        public Verkstad()
        {
            Vehicles = new List<Vehicle>();
        }

     
        public  void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public  void RemoveVehicle()
        {
            foreach (var v in Vehicles)
            {
                Console.WriteLine(v.PropertyList()); 
            }

            
        }

       
    }
}
