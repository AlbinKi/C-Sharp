using HabitatLibrary;
using System;
using System.Collections.Generic;

namespace Zoo
{
    class MainMenu
    {
        public static bool Switch (List<Habitat> habitatList)
        {
           

            Console.WriteLine("------------Huvudmeny------------");
            Console.WriteLine("\n[1]Inhängnader \n[2]Djur \n[3]Skötare");
            var menuswitcher = int.Parse(Console.ReadLine());

            switch (menuswitcher)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("------------Meny för inhängnad------------");
                        var habitat = Habitat.AddHabitat();
                        habitatList.Add(habitat);
                        break;
                    }

                case 2:
                    {

                        Console.WriteLine("Select habitat");
                        var habitatPrinter = int.Parse(Console.ReadLine());
                        switch (habitatPrinter)
                        {
                            case 1:
                                {
                                    var i = 0;
                                    var oasisList = new List<Oasis>();
                                    foreach (var habitat in habitatList)
                                    {
                                        var oasis = habitatList[i] as Oasis;
                                        i++;
                                        if (oasis != null)
                                        {
                                            oasisList.Add(oasis);
                                        }
                                    }
                                    Console.WriteLine(oasisList.Count);
                                    break;
                                }
                            case 2:
                                {
                                    var i = 0;
                                    var waterList = new List<Oasis>();
                                    foreach (var habitat in habitatList)
                                    {
                                        var water = habitatList[i] as Oasis;
                                        i++;
                                        if (water != null)
                                        {
                                            waterList.Add(water);
                                        }
                                    }
                                    Console.WriteLine(waterList.Count);
                                    break;
                                }
                            case 3:
                                {
                                    var i = 0;
                                    var forestCaveList = new List<ForestCave>();
                                    foreach (var habitat in habitatList)
                                    {
                                        var forestCave = habitatList[i] as ForestCave;
                                        i++;
                                        if (forestCave != null)
                                        {
                                            forestCaveList.Add(forestCave);
                                        }
                                    }
                                    Console.WriteLine(forestCaveList.Count);
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("------------Personal meny------------");
                        break;
                    }
                case 4:
                    {
                        return true;

                    }

            }
            return false;
        }
    }
}
