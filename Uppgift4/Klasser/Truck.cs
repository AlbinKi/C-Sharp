namespace Klasser
{
    class Truck : Vehicle
    {
        public int MaxLoad { get; set; }

        public Truck(string reg, string model, int weight, int meter, int maxload) : base(reg, model, weight, meter)
        {
            maxload = MaxLoad;
        }
    }

}
