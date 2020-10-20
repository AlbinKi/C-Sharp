using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Logic.Animals;
using Logic.Attributes;
namespace Logic.Habitats
{
    public class Habitat
    {
        [Translate("Mat som krävs", null)]
        public string FoodSource { get; set; }
        [Translate("Matförråd", null)]
        public int FoodSupply { get; set; }
        [Translate("habitatets namn", null)]
        public string HabitatName { get; set; }
        [Translate("Antal djur", null)]
        public int NumberOfAnimals { get; set; }
        [Translate("Antal arbetare", null)]
        public int NumberOfWorkers { get; set; }

        public List<Animal> Animals { get; set; }
        public List<Employee> Employees { get; set; }




        public Habitat(string foodsource, int foodsupply, string habitatname)
        {
            FoodSource = foodsource;
            FoodSupply = foodsupply;
            HabitatName = habitatname;

            Animals = new List<Animal>();
            Employees = new List<Employee>();


        }

        public static Habitat AddHabitat(int habitatchooser, Habitat habitat)
        {
            switch (habitatchooser)
            {

                case 1:
                    {
                        Oasis oasis = new Oasis(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return oasis;
                    }

                case 2:
                    {
                        Water water = new Water(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return water;
                    }

                case 3:
                    {
                        ForestCave forestcave = new ForestCave(habitat.FoodSource, habitat.FoodSupply, habitat.HabitatName);
                        return forestcave;
                    }
            }
            return null;

        }

        public static Habitat CreateHabitat(string name, int foodsupply, string foodsource)
        {

            Habitat habitat = new Habitat(foodsource, foodsupply, name);
            return habitat;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }



    }
}
