using System;

namespace AnimalLibrary
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



        private static Animal AssignAnimalProperties()
        {
            Console.WriteLine("Vad heter djuret?");
            var name = Console.ReadLine();
            Console.WriteLine("Hur gammalt är djuret?");
            var age = int.Parse(Console.ReadLine());


            Animal animal = new Animal(age, name);

            return animal;
        }


        public static Animal AddWorker()
        {
            string[] animals = new string[7] { "Apa", "Björn", "Delfin", "Elefant", "Giraff", "Lejon", "Pingvin" };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"[{i}] {animals[i]}");
            }


            Console.WriteLine("\n Skriv in siffran för den typ av skötare du vill lägga till.");
            var isNumber = true;
            var workerChooser = 0;

            do
            {
                if (!isNumber)
                {
                    Console.WriteLine("Ange endast en siffra mellan 1-7");
                }

                isNumber = int.TryParse(Console.ReadLine(), out workerChooser);

                if (workerChooser >= 8 || workerChooser <= 0)
                {
                    isNumber = false;
                }

            } while (!isNumber);



            switch (workerChooser)
            {
                case 1:

                    {
                        var animal = AssignAnimalProperties();
                        animal = new Monkey(animal.Age, animal.Name);
                        return animal;
                    }

                case 2:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Bear(animal.Age, animal.Name);
                        return animal;
                    }

                case 3:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Dolphine(animal.Age, animal.Name);
                        return animal;
                    }

                case 4:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Elephant(animal.Age, animal.Name);
                        return animal;
                    }

                case 5:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Giraffe(animal.Age, animal.Name);
                        return animal;
                    }

                case 6:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Lion(animal.Age, animal.Name);
                        return animal;
                    }

                case 7:
                    {
                        var animal = AssignAnimalProperties();
                        animal = new Penguin(animal.Age, animal.Name);
                        return animal;
                    }
            }
            return null;

        }




    }
}
