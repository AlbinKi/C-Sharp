using System;

namespace Logic.Animals
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }


        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
