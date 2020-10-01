using System.Collections.Generic;
using System;

namespace AnimalLibrary
{
    public class Animal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }


        public Animal(string species, int age, string name)
        {
            Species = species;
            Age = age;
            Name = name;  
        }
        private static Animal InitializeAnimal(string animaltype, string species)
        {
            Console.WriteLine($"Vad heter {animaltype}n?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hur gammal är {animaltype}");
            var age = int.Parse(Console.ReadLine());
           
            

            Animal animal = new Animal(species, age, name);
            return animal;
        }

        /// <summary>
        /// Adds a new habitat based on userinput
        /// </summary>
        public static void AddHabitat()
        {
            Console.WriteLine("\nVad för inhängnad vill du skapa?\n [1] Björn \n [2]  \n [3] Skog/Grotta");

            Console.WriteLine("\n Skriv in siffran för den typ av inhängnad du vill skapa.");
            var isNumber = int.TryParse(Console.ReadLine(), out var animalchooser);
            switch (animalchooser)
            {
                case 1:

                    {
                        var animaltype = "apan";
                        var species = "Apa";

                        var animal = InitializeAnimal(animaltype, species);
                        Monkey oasis = new Monkey(animal.Species, animal.Age, animal.Name);

                        break;
                    }

                case 2:
                    {
                        var animaltype = "Björnen";
                        var species = "Björn";

                        var animal = InitializeAnimal(animaltype, species);
                        Monkey oasis = new Monkey(animal.Species, animal.Age, animal.Name);

                        break;
                    }
                case 3:
                    {
                        var animaltype = "Delfinen";
                        var species = "Delfin";

                        var animal = InitializeAnimal(animaltype, species);
                        Monkey oasis = new Monkey(animal.Species, animal.Age, animal.Name);

                        break;
                    }
                case 4:
                    {
                        var animaltype = "Elefanten";
                        var species = "Elefant";
                    }



            }
}
