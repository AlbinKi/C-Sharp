﻿using System;
using System.Collections.Generic;
using AnimalLibrary;
namespace HabitatLibrary
{
    public class Habitat
    {
        public string FoodSource { get; set; }
        public int FoodSupply { get; set; }
        public string HabitatName { get; set; }
        public int NumberOfAnimals { get; set; }
        public static List <Animal> Animals { get; set; }



        public Habitat(string foodsource, int foodsupply, string habitatname)
        {
            FoodSource = foodsource;
            FoodSupply = foodsupply;
            HabitatName = habitatname;
           
        }

        public static void AddAnimalToHabitat(Animal animal, List<Animal> animallist)
        {
            animallist = new List<Animal>();
            animallist.Add(animal);
            Animals = animallist;

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
        public static void AddHabitat()
        {
            Console.WriteLine("\nVad för inhängnad vill du skapa?\n [1] Oas \n [2] Sjö/Vattenland \n [3] Skog/Grotta");

            Console.WriteLine("\n Skriv in siffran för den typ av inhängnad du vill skapa.");
            var isNumber = int.TryParse(Console.ReadLine(), out var habitatchooser);
           switch (habitatchooser){
                case 1:

                    {
                        var habitat = InitializeHabitat();
                        Oasis oasis = new Oasis(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                    
                        break;
                    }

                case 2:
                    {
                        var habitat = InitializeHabitat();
                        Water water = new Water(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        break;
                    }
                case 3:
                    {
                        var habitat = InitializeHabitat();
                        ForestCave forestcave = new ForestCave(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        break;
                    }
            }

        }
    }
}