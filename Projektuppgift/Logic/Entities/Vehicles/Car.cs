using Logic.Attributes;
using Logic.Entities.Vehicles;

namespace Klasser
{
    public class Car : Vehicle
    {
        [Translate ("Dragkrok", null)]
        public string Towbar { get; set; }

        public Car(string reg, string model, int weight, int meter, bool towbar) : base(reg, model, weight, meter)
        {
            if (towbar)
            {
                Towbar = "Ja";
            } else
            {
                Towbar = "Nej";
            }

        }
    }
}
