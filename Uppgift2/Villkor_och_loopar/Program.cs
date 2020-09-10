using System;

namespace Villkor_och_loopar
{

 
    class Program
    {
        static void Main(string[] args)
        {

            int leader = 0, competitors = 0, number, startHour, startMin, startSec, finHour, finMin, finSec;
            
            bool inputLoop = true, userInput = false, firstLoop = true;

            TimeSpan startTime, finTime, winner = new TimeSpan (0,0,0), contender = new TimeSpan(0,0,0);

         

            //Loopar tills det att användaren tilldelar ett startnummer som är mindre än <= 0
            while (inputLoop == true)
            {
                do
                {
                    
                    Console.WriteLine("Ange startnummer: ");
                    userInput = int.TryParse(Console.ReadLine(), out number);

                    if (userInput == false)
                    {
                        Console.WriteLine("Fel inmatning, försök igen!");
                    }

                    if (number > 0)
                    {
                        do
                        {
                            Console.WriteLine("Ange timme för start: ");
                            userInput = int.TryParse(Console.ReadLine(), out startHour);

                            if (userInput == false || startHour > 23 || startHour < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        do
                        {
                            Console.WriteLine("Ange minut för start: ");
                            userInput = int.TryParse(Console.ReadLine(), out startMin);

                            if (userInput == false || startMin > 60 || startMin < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        do
                        {
                            Console.WriteLine("Ange sekund för start: ");
                            userInput = int.TryParse(Console.ReadLine(), out startSec);

                            if (userInput == false || startSec > 60 || startSec < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        do
                        {
                            Console.WriteLine("Ange timme för mål: ");
                            userInput = int.TryParse(Console.ReadLine(), out finHour);

                            if (userInput == false || finHour > 23 || finHour < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        do
                        {
                            Console.WriteLine("Ange minut för mål: ");
                            userInput = int.TryParse(Console.ReadLine(), out finMin);

                            if (userInput == false || finMin > 60 || finMin < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        do
                        {
                            Console.WriteLine("Ange sekund för mål: ");
                            userInput = int.TryParse(Console.ReadLine(), out finSec);

                            if (userInput == false || finSec > 60 || finSec < 0)
                            {
                                Console.WriteLine("Fel inmatning, försök igen!");
                                userInput = false;
                            }

                        } while (userInput == false);

                        

                        
                        startTime = new TimeSpan(startHour, startMin, startSec);
                        finTime = new TimeSpan(finHour, finMin, finSec);

                        
                        //Om starttiden är större än sluttiden så läggs det på ett dygn på sluttiden för att få en korrekt beräkning 
                        if (startTime > finTime)
                        {
                            finTime = new TimeSpan(1, finHour, finMin, finSec);
                        }

                        //Beräknar deltagarens tid
                        if (finTime > startTime)
                        {
                            contender = finTime - startTime;
                        }

                        //Kontroll för att se till så att första deltagaren automatiskt blir ledaren oavsett tid
                        if (firstLoop == true)
                        {
                            winner = contender;
                            leader = number;
                            firstLoop = false;
                        }

                        //Jämför den nya deltagaren mot den ledande
                        if (contender < winner)
                        {
                            winner = contender;
                            leader = number;
                        }

                        //plussar på antalet deltagare
                        ++competitors;
                       
                    }
                    else { inputLoop = false; }

                }
                while (userInput == false);
            }

            //Skriver ut resultatet
            Console.WriteLine();
            Console.WriteLine("Vinnaren är: " + leader);
            Console.WriteLine("Vinnartiden: " + winner);
            Console.WriteLine("Antal tävlande: " + competitors);

            
            
        }
    }
}
