using AnimalLibrary;
using HabitatLibrary;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var habitatList = new List<Habitat>();
            var exit = false;

            while (!exit)
            {
                exit = MainMenu.Switch(habitatList);
            }
        }
    }
}
