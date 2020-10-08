using CustomAttribute;

namespace Klasser
{
    
    public class Bus : Vehicle
    {
        [Translate("Maxantal passagerare", null)]
        public int MaxPassenger { get; set; }

        public Bus(string reg, string model, int weight, int meter, int maxpassenger) : base(reg, model, weight, meter)
        {
            MaxPassenger = maxpassenger;
        }
    }
}
