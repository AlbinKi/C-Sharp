using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using AnimalLibrary;
using PersonellLibrary;
namespace HabitatLibrary
{
    public class Habitat
    {
        public string FoodSource { get; set; }
        public int FoodSupply { get; set; }
        public string HabitatName { get; set; }
        public int NumberOfAnimals { get; set; }

        public int NumberOfWorkers { get; set; }

        public List<Animal> Animals { get; set; }
        public List<Personell> Workers { get; set; }




        public Habitat(string foodsource, int foodsupply, string habitatname)
        {
            FoodSource = foodsource;
            FoodSupply = foodsupply;
            HabitatName = habitatname;

            Animals = new List<Animal>();
            Workers = new List<Personell>();

         
        }

      
        private static Habitat InitializeHabitat()
        {
            Console.WriteLine("Vad heter inhängnaden?");
            var name= Console.ReadLine();
            Console.WriteLine("Vad för mat kräver inhängnaden?");
            var foodsource = Console.ReadLine();
            Console.WriteLine("Hur mycket mat finns tillgänglig i inhängnaden?");
            var foodsupply = int.Parse(Console.ReadLine());

            Habitat habitat = new Habitat(foodsource, foodsupply, name);
            
            return habitat;
        }

        /// <summary>
        /// Adds a new habitat based on userinput
        /// </summary>
        public static Habitat AddHabitat() 
        {
            Console.WriteLine("\nVad för inhängnad vill du skapa?\n [1] Oas \n [2] Sjö/Vattenland \n [3] Skog/Grotta");

            Console.WriteLine("\n Skriv in siffran för den typ av inhängnad du vill skapa.");
            var isNumber = true;
            var habitatchooser = 0;

            do
            {
                if (!isNumber)
                {
                    Console.WriteLine("Ange endast en siffra mellan 1-3");
                }

                isNumber = int.TryParse(Console.ReadLine(), out habitatchooser);

                if (habitatchooser >= 4 || habitatchooser <= 0)
                {
                    isNumber = false;
                }

            } while (!isNumber);

            

           switch (habitatchooser){
                case 1:

                    {
                        var habitat = InitializeHabitat();                
                        Oasis oasis = new Oasis(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return oasis;
                        
                    }

                case 2:
                    {
                        var habitat = InitializeHabitat();
                        Water water = new Water(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return water;
                        
                    }
                case 3:
                    {
                        var habitat = InitializeHabitat();
                        ForestCave forestcave = new ForestCave(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return forestcave;
                    }
            }
            return null;

        }
        
        
    }
}
