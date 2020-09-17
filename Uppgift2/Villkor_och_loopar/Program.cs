using System;

namespace Villkor_och_loopar
{


    class Program
    {
        static void Main(string[] args)
        {

            int leader = 0, competitors = 0, number, startHour, startMin, startSec, finHour, finMin, finSec, contender, winner = 0, winHour = 0, winMin = 0, winSec = 0,
                runnerUp = 90000, runnerUpHr = 0, runnerUpMin = 0, runnerUpSec = 0, runnerUpNumber = 0;

            bool inputLoop = true, userInput = false, firstLoop = true;


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

                        //Lägg till en till deltagare
                        ++competitors;

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




                        //Deltagarens tid i sekunder
                        contender = (finSec - startSec) + ((finHour - startHour) * 3600) + ((finMin - startMin) * 60);

                        

                        //Om starttiden är efter sluttiden lägg till 24 timmar på deltagarens tid
                        if (contender < 0)
                        {
                            contender += 86400;
                        }




                        if (contender < winner || firstLoop == true)
                        {

                            //Byter ut nuvarande vinnare till runner up
                            if (firstLoop == false)
                            {
                                runnerUpNumber = leader;
                                runnerUp = winner;
                                runnerUpHr = winHour;
                                runnerUpMin = winMin;
                                runnerUpSec = winSec;
                            }

                            //Nya deltagaren till vinnare
                            winner = contender;
                            winHour = finHour - startHour;
                            winMin = finMin - startMin;
                            winSec = finSec - startSec;


                            //Om sekunder är negativa så räknar den ut kvarvarande sekunder och tar bort en minut
                            if (winSec < 0)
                            {
                                winSec += 60;
                                --winMin;
                            }

                            //Samma som innan fast med minuter och timmar
                            if (winMin < 0)
                            {
                                winMin += 60;
                                --winHour;
                            }

                            // ger det korrekta positiva talet om timman är negativ
                            if (winHour < 0)
                            {
                                winHour += 24;
                            }


                            leader = number;
                            firstLoop = false;

                        }

                        //Kollar om andraplatsen bör uppdateras
                        if (contender < runnerUp && contender > winner)
                        {
                            runnerUp = contender;
                            runnerUpHr = finHour - startHour;
                            runnerUpMin = finMin - startMin;
                            runnerUpSec = finSec - startSec;
                            runnerUpNumber = number;


                            if (runnerUpSec < 0)
                            {

                                runnerUpSec += 60;
                                --runnerUpMin;
                            }


                            if (runnerUpMin < 0)
                            {
                                runnerUpMin += 60;
                                --runnerUpHr;
                            }

                            if (runnerUpHr < 0)
                            {
                                runnerUpHr += 24;
                            }




                        }
                    }
                    else
                    {
                        //Skrivs ut om det inte finns några tävlare
                        if (competitors == 0)
                        {
                            Console.WriteLine("Inga tävlande.");
                        }

                        inputLoop = false;

                    }

                }
                while (userInput == false);
            }

            //Skriver ut resultatet
            if (competitors != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vinnaren är: " + leader);
                Console.WriteLine("Vinnartiden: " + winHour + " timmar " + winMin + " minuter " + winSec + " sekunder");
                Console.WriteLine("Antal tävlande: " + competitors);

                //Skriver bara ut andraplatsens tid om det är 2 eller fler deltagare
                if (competitors >= 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Andraplats: " + runnerUpNumber);
                    Console.WriteLine("Tid: " + runnerUpHr + " timmar " + runnerUpMin + " minuter " + runnerUpSec + " sekunder");
                }

            }




        }
    }
}
