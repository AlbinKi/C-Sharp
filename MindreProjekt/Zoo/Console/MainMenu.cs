//using Logic;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp
//{
//    class MainMenu
//    {
//        public static bool Switch(List<Habitat> habitatList)
//        {
//            Console.WriteLine("------------Huvudmeny------------");
//            Console.WriteLine("\n[1]Inhängnader \n[2]Djur \n[3]Skötare");

//            var menuswitcher = int.Parse(Console.ReadLine());

//            switch (menuswitcher)
//            {
//                case 1:
//                    {
//                        HabitatMenu.Menu(habitatList);
//                        break;
//                    }

//                case 2:
//                    {
                        
//                        Console.WriteLine("Select habitat");
//                        var habitatPrinter = int.Parse(Console.ReadLine());
//                        switch (habitatPrinter)
//                        {
//                            case 1:
//                                {
                                  
//                                    foreach (var habitat in habitatList.OfType<Oasis>())
//                                    {
//                                        Console.WriteLine(habitat.HabitatName + habitat.FoodSource + habitat.FoodSupply);

//                                    }
//                                    break;
//                                }
//                            case 2:
//                                {
                                   
//                                    foreach (var habitat in habitatList.OfType<Water>())
//                                    {
//                                        Console.WriteLine();

//                                    }
//                                    break;
//                                }
//                            case 3:
//                                {
                                 
//                                    foreach (var habitat in habitatList.OfType<ForestCave>())
//                                    {
//                                        Console.WriteLine(habitat.HabitatName + habitat.FoodSource + habitat.FoodSupply);
                                        
//                                    }
//                                    break;
//                                }
//                        }
                        
//                        break;
//                    }
//                case 3:
//                    {
//                        Console.Clear();
//                        PersonellMenu.Menu(habitatList);
//                        break;
//                    }
//                case 4:
//                    {
//                        return true;

//                    }

//            }
//            return false;
//        }
//    }
//}
