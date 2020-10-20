namespace Logic
{
    public class GiraffeDude:Employee
    {

        public GiraffeDude(string name, int age) : base(name, age)
        {
            Competence = "Måste vara lång";
        }
    }
}
