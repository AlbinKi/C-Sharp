namespace PersonellLibrary
{
    public class GiraffeDude:Personell
    {

        public GiraffeDude(string name, int age) : base(name, age)
        {
            Competence = "Måste vara lång";
        }
    }
}
