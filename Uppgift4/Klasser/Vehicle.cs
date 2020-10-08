using CustomAttribute;
using ExtensionMethods;
using System;

namespace Klasser
{
    public  class Vehicle
    {
        [Translate("Registreringsnummer", null)]
        public string Reg { get; set; }
        [Translate("Modell", null)]
        public string Model { get; set; }
        [Translate("Tyngd", "kg")]
        public int Weight { get; set; }
        [Translate("Mätaren", "mil")]
        public int Meter { get; set; }
        [Translate("Lämnades in till verkstaden", null)]
        public DateTime RegisterDate { get; set; }

        public Vehicle(string reg, string model, int weight, int meter)
        {
            Reg = reg;
            Model = model;
            Weight = weight;
            Meter = meter;
            RegisterDate = DateTime.Now;
        }

        private static Vehicle CreateVehicle(string vehicletype)
        {
            Console.Clear();
            Console.WriteLine($"Ange {vehicletype}s registeringsnummer");
            var reg = Console.ReadLine();
            Console.WriteLine($"Ange {vehicletype}s modell");
            var model = Console.ReadLine();
            Console.WriteLine($"Ange {vehicletype}s vikt");
            var weight = Console.ReadLine().Parse<int>();
            Console.WriteLine($"Ange hur många mil {vehicletype} har gått");
            var meter = Console.ReadLine().Parse<int>();
            var vehicle = new Vehicle(reg, model, weight, meter);
            return vehicle;
        }

        public static Vehicle GetVehicleToAdd()
        {
            Console.Clear();
            Console.WriteLine("[1] Personbil");
            Console.WriteLine("[2] Buss");
            Console.WriteLine("[3] Motorcykel");
            Console.WriteLine("[4] Lastbil");
            var vehicleselector = Console.ReadLine().Parse<int>();

         

            switch (vehicleselector)
            {
                case 1:
                    {
                        var vehicletype = "bilen";
                        var vehicle = CreateVehicle(vehicletype);

                        Console.WriteLine("Har bilen en dragkrok?");

                        var towbar = Console.ReadLine().ToBool();

                        var car = new Car(vehicle.Reg, vehicle.Model, vehicle.Weight, vehicle.Meter, towbar);
                        return car;
                    }
                case 2:
                    {
                        var vehicletype = "bussen";
                        var vehicle = CreateVehicle(vehicletype);

                        Console.WriteLine("Vad är bussens antal maxpassagerare");
                        var maxpassenger = Console.ReadLine().Parse<int>();

                        var bus = new Bus(vehicle.Reg, vehicle.Model, vehicle.Weight, vehicle.Meter, maxpassenger);
                        return bus;
                    }
                case 3:
                    {
                        var vehicletype = "motorcykeln";
                        var vehicle = CreateVehicle(vehicletype);
                        Console.WriteLine("Vad är motorcykelns maxhastighet");
                        var maxspeed = Console.ReadLine().Parse<int>();
                        var motorcycle = new Motorcycle(vehicle.Reg, vehicle.Model, vehicle.Weight, vehicle.Meter, maxspeed);
                        return motorcycle;
                    }
                case 4:
                    {
                        var vehicletype = "lastbilen";
                        var vehicle = CreateVehicle(vehicletype);
                        Console.WriteLine("Vad är lastbilens maxlast");
                        var maxload = Console.ReadLine().Parse<int>();
                        var truck = new Truck(vehicle.Reg, vehicle.Model, vehicle.Weight, vehicle.Meter, maxload);
                        return truck;
                    }
                default:
                    {
                        Console.WriteLine("Siffran du angav stämmer inte överens med något av valen, försök igen. Tryck på en knapp för att återgå till huvudmenyn");
                        Console.ReadKey();
                        return null;
                    }                   
            }

        }
    }
}
