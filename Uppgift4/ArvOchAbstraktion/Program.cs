using ExtensionMethods;
using Klasser;
using System;
using System.Linq;

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
                Console.Clear();
                Console.WriteLine("Huvudmeny");
                Console.WriteLine("[1] Lägg till ett ny fordon i verkstaden");
                Console.WriteLine("[2] Ta bort ett fordon från verkstaden");
                Console.WriteLine("[3] Exit");
                int menuControl = Console.ReadLine().Parse<int>();

                switch (menuControl)
                {
                    //Meny för att lägga till fordon
                    case 1:
                        {
                            var vehicle = Vehicle.GetVehicleToAdd();
                            if (vehicle != null)
                            {
                                verkstad.AddVehicle(vehicle);
                                Console.WriteLine($"Fordonet har lagts in på verkstaden {vehicle.RegisterDate}");
                                Console.WriteLine("Tryck på en knapp för att fortsätta...");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }
                    //Meny för att ta bort fordon
                    case 2:
                        {
                            //Kollar så att det finns fordon in listan om det inte gör det så skickar den ett felmeddelande och hoppar tillbaka till startmenyn
                            if (verkstad.Vehicles.Any())
                            {
                                Console.Clear();
                                Console.WriteLine("Vad för fordonstyp vill du skriva ut från verkstaden?");
                                Console.WriteLine("[1] Personbil \n[2] Buss \n[3] Motorcykel \n[4] Lastbil \n[5] Visa alla fordonstyper");
                                menuControl = Console.ReadLine().Parse<int>();

                                switch (menuControl)
                                {
                                    case 1:
                                        {
                                           
                                            //Skriver ut en lista på alla Bilar och dess egenskaper
                                            Console.Clear();
                                            Console.WriteLine("--------------Bilar--------------");
                                            verkstad.Vehicles.PrintListProperties<Car,Vehicle>();
                                            ///Kollar vilket fordon som ska tas bort med hjälp av en extensionmethod. 
                                            object vehicle = null;
                                            while (vehicle == null)
                                            {
                                                vehicle = verkstad.Vehicles.GetObjectFromList<Car, Vehicle>(Console.ReadLine(), "Reg");
                                                if (vehicle == null)
                                                {
                                                    Console.WriteLine("Registreringsnumret du angav stämde inte överens med någon bil i registret.");
                                                    Console.WriteLine("Vill du försöka igen?");
                                                    var userinput = Console.ReadLine().ToBool();
                                                    if (!userinput)
                                                    {
                                                        break;
                                                    }
                                                    if (userinput)
                                                    {
                                                        Console.WriteLine("Ange registreringsnumret på den bil som du vill ta bort");
                                                    }
                                                }
                                            }
                                            verkstad.RemoveVehicle(vehicle as Vehicle);
                                            break;
                                        }
                                    case 2:
                                        {
                                            //Skriver ut en lista på alla Bussar och dess egenskaper
                                            Console.Clear();
                                            Console.WriteLine("--------------Bussar--------------");
                                            verkstad.Vehicles.PrintListProperties<Bus, Vehicle>();
                                            ///Kollar vilket fordon som ska tas bort med hjälp av en extensionmethod. 
                                            object vehicle = null;
                                            while (vehicle == null)
                                            {
                                                vehicle = verkstad.Vehicles.GetObjectFromList<Bus, Vehicle>(Console.ReadLine(), "Reg");
                                                if (vehicle == null)
                                                {
                                                    Console.WriteLine("Registreringsnumret du angav stämde inte överens med någon buss i registret.");
                                                    Console.WriteLine("Vill du försöka igen?");
                                                    var userinput = Console.ReadLine().ToBool();
                                                    if (!userinput)
                                                    {
                                                        break;
                                                    }
                                                    if (userinput)
                                                    {
                                                        Console.WriteLine("Ange registreringsnumret på bussen som du vill ta bort");
                                                    }
                                                }
                                            }
                                            verkstad.RemoveVehicle(vehicle as Vehicle);
                                            break;
                                        }
                                    case 3:
                                        {
                                            //Skriver ut en lista på alla motorcyklar och dess egenskaper
                                            Console.Clear();
                                            Console.WriteLine("--------------Motorcyklar--------------");
                                            verkstad.Vehicles.PrintListProperties<Motorcycle, Vehicle>();
                                            ///Kollar vilket fordon som ska tas bort med hjälp av en extensionmethod. 
                                            object vehicle = null;
                                            while (vehicle == null)
                                            {
                                                vehicle = verkstad.Vehicles.GetObjectFromList<Motorcycle, Vehicle>(Console.ReadLine(), "Reg");
                                                if (vehicle == null)
                                                {
                                                    Console.WriteLine("Registreringsnumret du angav stämde inte överens med någon motorcykel i registret.");
                                                    Console.WriteLine("Vill du försöka igen?");
                                                    var userinput = Console.ReadLine().ToBool();
                                                    if (!userinput)
                                                    {
                                                        break;
                                                    }
                                                    if (userinput)
                                                    {
                                                        Console.WriteLine("Ange registreringsnumret på den motorcykel som du vill ta bort");
                                                    }
                                                }
                                            }
                                            verkstad.RemoveVehicle(vehicle as Vehicle);
                                            break;
                                        }
                                    case 4:
                                        {
                                            //Skriver ut en lista på alla lastbilar och dess egenskaper
                                            Console.Clear();
                                            Console.WriteLine("--------------Lastbilar--------------");
                                            verkstad.Vehicles.PrintListProperties<Truck, Vehicle>();
                                            ///Kollar vilket fordon som ska tas bort med hjälp av en extensionmethod. 
                                            object vehicle = null;
                                            while (vehicle == null)
                                            {
                                                vehicle = verkstad.Vehicles.GetObjectFromList<Truck, Vehicle>(Console.ReadLine(), "Reg");
                                                if (vehicle == null)
                                                {
                                                    Console.WriteLine("Registreringsnumret du angav stämde inte överens med någon lastbil i registret.");
                                                    Console.WriteLine("Vill du försöka igen?");
                                                    var userinput = Console.ReadLine().ToBool();
                                                    if (!userinput)
                                                    {
                                                        break;
                                                    }
                                                    if (userinput)
                                                    {
                                                        Console.WriteLine("Ange registreringsnumret på den lastbil som du vill ta bort");
                                                    }
                                                }
                                            }
                                            verkstad.RemoveVehicle(vehicle as Vehicle);
                                            break;
                                        }
                                    case 5:
                                        {
                                            //Skriver ut en lista på alla fordon och dess egenskaper
                                            Console.Clear();
                                            Console.WriteLine("--------------Bilar--------------");
                                            verkstad.Vehicles.PrintListProperties<Car, Vehicle>();

                                            Console.WriteLine("--------------Bussar--------------");
                                            verkstad.Vehicles.PrintListProperties<Bus, Vehicle>();

                                            Console.WriteLine("--------------Motorcyklar--------------");
                                            verkstad.Vehicles.PrintListProperties<Motorcycle, Vehicle>();

                                            Console.WriteLine("--------------Lastbilar--------------");
                                            verkstad.Vehicles.PrintListProperties<Truck, Vehicle>();

                                            ///Kollar vilket fordon som ska tas bort med hjälp av en extensionmethod. 
                                            object vehicle = null;
                                            while (vehicle == null)
                                            {
                                                vehicle = verkstad.Vehicles.GetObjectFromList<Vehicle, Vehicle>(Console.ReadLine(), "Reg");
                                                if (vehicle == null)
                                                {
                                                    Console.WriteLine("Registreringsnumret du angav stämde inte överens med något fordon i registret.");
                                                    Console.WriteLine("Vill du försöka igen?");
                                                    var userinput = Console.ReadLine().ToBool();
                                                    if (!userinput)
                                                    {
                                                        break;
                                                    }
                                                    if (userinput)
                                                    {
                                                        Console.WriteLine("Ange registreringsnumret på det fordon du vill ta bort");
                                                    }
                                                }
                                            }
                                            verkstad.RemoveVehicle(vehicle as Vehicle);
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Siffran du angav stämmer inte överens med något av valen, försök igen. Tryck på en knapp för att återgå till huvudmenyn");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                //Felmeddelande om det inte finns några fordon att ta bort
                                Console.Clear();
                                Console.WriteLine("Verkstaden har inga fordon inlagda för tillfället tryck på valfri tangent för att återgå till huvudmenyn");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        }

                    //Stänger ner applikationen
                    case 3:
                        {
                            exit = true;
                            break;
                        }
                       //Felmeddelande
                    default:
                        {
                            Console.WriteLine("Siffran du angav stämmer inte överens med något av valen, försök igen. Tryck på en knapp för att återgå till huvudmenyn");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
