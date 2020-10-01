namespace PersonellLibrary
{
    public class Personell
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Competence { get; set; }

        public Personell(string name, int age)
        {
            Name = name;
            Age = age;
            
        }


    }
}
