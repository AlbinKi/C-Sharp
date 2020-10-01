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


        /// <summary>
        /// Frågar användan vilken typ av djur som ska skapas, körs bara om det finns tidigare skapade inhängnanden
        /// </summary>
        public static void NewAnimal()
        {
            Console.WriteLine("\nVad för djur vill du lägga till? \n[1] Apa \n[2] Björn \n[3] Delfin \n[4] Elefant \n[5] Giraff \n[6] Lejon \n[7] Pingvin");

            Console.WriteLine("\nSkriv in siffran för den typ av inhängnad du vill skapa.");
            var isNumber = int.TryParse(Console.ReadLine(), out var animalchooser);
            switch (animalchooser)
            {
                case 1:

                    {
                        var animaltype = "apan";
                        var species = "Apa";

                        var animal = CreateAnimal(animaltype, species);
                        Monkey monkey = new Monkey(animal.Species, animal.Age, animal.Name);

                        break;
                    }

                case 2:
                    {
                        var animaltype = "Björnen";
                        var species = "Björn";

                        var animal = CreateAnimal(animaltype, species);
                        Bear bear = new Bear(animal.Species, animal.Age, animal.Name);

                        break;
                    }
                case 3:
                    {
                        var animaltype = "Delfinen";
                        var species = "Delfin";

                        var animal = CreateAnimal(animaltype, species);
                        Dolphine dolphine = new Dolphine(animal.Species, animal.Age, animal.Name);

                        break;
                    }
                case 4:
                    {
                        var animaltype = "Elefanten";
                        var species = "Elefant";

                        var animal = CreateAnimal(animaltype, species);
                        Elephant elephant = new Elephant(animal.Species, animal.Age, animal.Name);
                        break;
                    }

                case 5:
                    {
                        var animaltype = "Giraffen";
                        var species = "Giraff";

                        var animal = CreateAnimal(animaltype, species);
                        Giraffe giraffe = new Giraffe(animal.Species, animal.Age, animal.Name);
                        break;
                    }

                case 6:
                    {
                        var animaltype = "Lejonet";
                        var species = "Lejon";

                        var animal = CreateAnimal(animaltype, species);
                        Lion lion = new Lion(animal.Species, animal.Age, animal.Name);
                        break;
                    }
                case 7:
                    {
                        var animaltype = "Pingvinen";
                        var species = "Pingvin";

                        var animal = CreateAnimal(animaltype, species);
                        Penguin penguin = new Penguin(animal.Species, animal.Age, animal.Name);
                        break;
                    }
            }
        }

        /// <summary>
        /// Låter användaren svara på frågor kring djuret för att sedan returnera ett djur. animaltype == djurets bestämda form  species == obestämd form
        /// </summary>
        /// <param name="animaltype"></param>
        /// <param name="species"></param>
        /// <returns></returns>
        private static Animal CreateAnimal(string animaltype, string species)
        {
            Console.WriteLine($"Vad heter {animaltype}?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hur gammal är {animaltype}");
            var age = int.Parse(Console.ReadLine());



            Animal animal = new Animal(species, age, name);
            return animal;
        }

       
    }
}
