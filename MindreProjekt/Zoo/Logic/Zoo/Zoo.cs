using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Logic.Animals;
using Logic.Habitats;
using Logic.DAL;

namespace Logic.Zoo
{
    public class Zoo
    {
        public  List <Habitat> Habitats { get; set;}
        public List <Animal> Animals { get; set; }
        public List <Employee> Employees { get; set; }
        public Zoo()
        {
            Habitats = HabitatDataAccess.LoadHabitats();
            Animals = new List<Animal>();
            Employees = new List<Employee>();
             
        }

        public  void AddHabitat(Habitat habitat)
        {
            Habitats.Add(habitat);
            HabitatDataAccess.AddHabitatToDB(Habitats);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddAnimal (Animal animal)
        {
            Animals.Add(animal);
        }
        public void PrintHabitats(Habitat habitat)
        {
            AddHabitat(habitat);
           
        }
    }
}
