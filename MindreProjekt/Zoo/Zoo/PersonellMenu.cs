using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HabitatLibrary;
using PersonellLibrary;

namespace Zoo
{
    class PersonellMenu
    {
        public static void Menu(List <Habitat> habitats)
        {
            {
                Console.Clear();
                Console.WriteLine("------------Personalmeny------------");
                Console.WriteLine("[1] Lägg till en anställd");
                Console.WriteLine("[2] Ta bort en anställd");
                Console.WriteLine("[3] Gå tillbaka till huvudmenyn");

                var habitatmenu = int.Parse(Console.ReadLine());

                switch (habitatmenu)
                {
                    case 1:
                        {
                            Console.Clear();
                            var worker = Personell.AddWorker();

                            Console.WriteLine("Vilken typ av inhängnad vill du att skötaren ska jobba inom?");

                            var habitatSelector = int.Parse(Console.ReadLine());

                            switch (habitatSelector)
                            {
                                case 1:
                                    {
                                        var inputMatch = false;
                                        while (!inputMatch)
                                        {
                                            foreach (var habitat in habitats.OfType<Oasis>())
                                            {
                                                Console.WriteLine($"Inhängnadens namn: {habitat.HabitatName} Antal djur: {habitat.Animals.Count} Antal skötare: {habitat.Workers.Count}");
                                            }

                                            Console.WriteLine("Skriv in namnet på den oas du vill att personen ska arbeta inom");

                                            var userInput = Console.ReadLine();


                                            foreach (var habitat in habitats.OfType<Oasis>())
                                            {
                                                if (userInput == habitat.HabitatName)
                                                {
                                                    habitat.Workers.Add(worker);
                                                    inputMatch = true;
                                                }

                                                if (habitat == habitats.Last<Habitat>() && userInput != habitat.HabitatName)
                                                {
                                                    Console.WriteLine("Finns ingen inhängnad vid det angivna namnet");
                                                    inputMatch = false;
                                                }
                                            }
                                        }
                                        break;
                                    }

                                case 2:
                                    {
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                            }
                            

                            break;
                        }

                    case 2:
                        {
                            break;
                        }

                    case 3:
                        {
                            break;
                        }
                }
            }
        }
    }
}
