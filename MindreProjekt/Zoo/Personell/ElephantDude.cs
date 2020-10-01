namespace PersonellLibrary
{
    public class ElephantDude:Personell
    {

        public ElephantDude(string name, int age) : base(name, age)
        {
            Competence = "Hålla elefanterna lugn AKA Elefantviskaren";
        }
    }
}
