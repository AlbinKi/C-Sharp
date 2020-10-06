namespace Klasser
{
    public class Car : Vehicle
    {
        public bool Towbar { get; set; }

        public Car(string reg, string model, int weight, int meter, bool towbar) : base(reg, model, weight, meter)
        {
            Towbar = towbar;
        }
    }
}
