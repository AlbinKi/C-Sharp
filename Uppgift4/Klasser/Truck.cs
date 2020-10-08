using CustomAttribute;
namespace Klasser
{
    public class Truck : Vehicle
    {
        [Translate ("Maxlast", "kg")]
        public int MaxLoad { get; set; }

        public Truck(string reg, string model, int weight, int meter, int maxload) : base(reg, model, weight, meter)
        {
            MaxLoad = maxload;
        }
    }

}
