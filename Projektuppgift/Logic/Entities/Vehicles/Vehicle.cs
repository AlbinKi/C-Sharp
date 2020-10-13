using Logic.Attributes;
using System;


namespace Logic.Entities.Vehicles
{
    public class Vehicle
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



    }
}
