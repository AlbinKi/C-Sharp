using Logic.Attributes;
using Logic.Entities.Vehicles;

namespace Klasser
{
    public class Motorcycle : Vehicle
    {
        [Translate("Maxhastighet", "km/h")]
        public int MaxSpeed { get; set; }

        public Motorcycle(string reg, string model, int weight, int meter, int maxspeed) : base(reg, model, weight, meter)
        {
            MaxSpeed = maxspeed;
        }
    }
}
