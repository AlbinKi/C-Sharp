namespace PersonellLibrary
{
    public class LionDude:Personell
    {

        public LionDude(string name, int age) : base(name, age)
        {
            Competence = "Kan tämja lejon";
        }
    }
}
