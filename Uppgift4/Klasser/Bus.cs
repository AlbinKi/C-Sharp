namespace Klasser
{

    class Bus : Vehicle
    {
        public int MaxPassenger { get; set; }

        public Bus(string reg, string model, int weight, int meter, int maxpassenger) : base(reg, model, weight, meter)
        {
            maxpassenger = MaxPassenger;
        }
    }
}
