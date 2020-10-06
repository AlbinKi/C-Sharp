namespace Klasser
{
    class Motorcycle : Vehicle
    {
        public int MaxSpeed { get; set; }

        public Motorcycle(string reg, string model, int weight, int meter, int maxspeed) : base(reg, model, weight, meter)
        {
            maxspeed = MaxSpeed;
        }
    }
}
