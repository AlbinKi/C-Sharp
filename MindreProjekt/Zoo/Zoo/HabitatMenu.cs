using HabitatLibrary;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Zoo
{
    class HabitatMenu
    {

        public static void Menu(List<Habitat> habitatlist)
        {
            {
                Console.Clear();
                Console.WriteLine("------------Meny för inhängnad------------");
                Console.WriteLine("[1] Lägg till en ny inhängnad");
                Console.WriteLine("[2] Ta bort en inhängnad");
                Console.WriteLine("[3] Gå tillbaka till huvudmenyn");

                var habitatmenu = int.Parse(Console.ReadLine());

                switch (habitatmenu)
                {
                    case 1:
                        {
                            var habitat = Habitat.AddHabitat();
                            habitatlist.Add(habitat);
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
