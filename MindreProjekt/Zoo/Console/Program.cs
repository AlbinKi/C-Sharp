
using System;
using System.Collections.Generic;
using System.Linq;
using Logic.Habitats;
using Logic.DAL;
using Logic.Zoo;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Habitat habitat = new Habitat("qwe", 2, "2354");
            Habitat we = new Habitat("sd", 2, "dcv");
            Zoo zoo = new Zoo();


            zoo.PrintHabitats(we);
           

          


        }
    }
}