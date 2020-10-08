using Klasser;
using System.Collections.Generic;

namespace ArvOchAbstraktion
{
    public interface IVerkstad
    {
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle);
        public void RemoveVehicle(Vehicle vehicle);
       
    }
}
