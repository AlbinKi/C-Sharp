using Klasser;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using ExtensionMethods;

namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;
            var verkstad = new Verkstad();

            while (!exit)
            {
                Console.WriteLine("Huvudmeny");
                Console.WriteLine("[1] Lägg till ett ny fordon i verkstaden");
                Console.WriteLine("[2] Ta bort ett fordon från verkstaden");
                Console.WriteLine("[3] Se över alla fordon i verkstaden");
                Console.WriteLine("[4] Exit");
                int menuControl = Console.ReadLine().Parse<int>();

                while (menuControl >= 5 || menuControl <= 0)
                {
                    Console.WriteLine("Siffran du angav stämmer inte överens med något av valen, försök igen.");
                    menuControl = Console.ReadLine().Parse<int>();
                }

         
                switch (menuControl)
                {
                    case 1:
                        {
                            var vehicle =  Vehicle.GetVehicleToAdd();
                            verkstad.AddVehicle(vehicle);
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            verkstad.RemoveVehicle();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            
                            exit = true;
                            break;
                        }
                }
            }
        }
    }
}
