using System;
using System.Collections.Generic;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            bool loopCars = true, loopPersons = true;

            //Loopar inmatning av personer och bilar tills användaren är färdig
            do
            {
                var name = GetString("Ange personens namn: ");
                var age = GetInt("\nAnge personens ålder");

                //Lägger till personens egenskaper i objektet för att sedan lägga in objektet i en lista
                Person person = new Person(name, age);
                PersonList.Add(person);

                do
                {
                    var model = GetString("\nVad är det för bilmodell: ");
                    var reg = GetString("\nVad är bilens registreringsnummer: ");
                    var electric = GetBool("Är det en elbil: ");

                    //Lägger till bilens egenskaper i objektet för att sedan lägga in objektet i en lista
                    Car car = new Car(model, reg.ToUpper(), 2000, electric);
                    person.Cars.Add(car);

                    loopCars = GetBool("\nVill du registrera en ny bil på personen?");

                } while (loopCars == true);

                loopPersons = GetBool("\nVill du registrera en ny person?");

            } while (loopPersons); 

            //Loop som låter användaren skriva ut information om valfri person tills användaren ber om att få avsluta programmet.
            var print = true;
            while (print)
            {

                PrintList(PersonList);

                var personIndex = GetInt("Skriv in siffran på den person vars bilar du vill se: ");
                personIndex--;

                //Skriver ut personen vars index överensstämmer med inmatning för att sedan skriva ut personens bilar. 
                Console.WriteLine($"\nNamn: {PersonList[personIndex].Name} \nÅlder: {PersonList[personIndex].Age}");

                foreach (var c in PersonList[personIndex].Cars)
                {
                    Console.WriteLine($"\n  Bilmodell: {c.Model}\n  Registreringsnummer: {c.Reg}\n  Elbil: {c.Electric}\n  Datum för registrering: {c.RegisterDate}");
                }

                bool userInput = GetBool("\nVill du se en annan persons bilar?");

                if (userInput)
                {
                    print = true;
                }
                else 
                {
                    print = false; 
                }
            }
        }

        /// <summary>
        /// Returnerar ett booleskt svar i ja eller nej form på en inmatad fråga.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        static bool GetBool(string question)
        {
            bool input = true, returnanswer = true;

            do
            {
                if (!input)
                {
                    Console.WriteLine("\nange endast ja eller nej!\n");
                }

                Console.WriteLine(question);

                var answer = Console.ReadLine().ToLower();

                if (answer == "ja")
                {
                    input = true;


                }
                else if (answer == "nej")
                {
                    returnanswer = false;
                    input = true;
                }

            } while (input == false);



            return returnanswer;
        }

        /// <summary>
        /// Returnerar ett svar på en inmatad fråga.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// Returnerar ett svar i siffror på inmatad fråga.
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public static int GetInt(string question)
        {
            bool input = true;
            int age;
            do
            {
                if (!input)
                {
                    Console.WriteLine("\nAnge svaret i siffror!\n");
                }

                Console.WriteLine(question);
                input = int.TryParse(Console.ReadLine(), out age);

            } while (!input);

            return age;
        }

        /// <summary>
        /// Skriver ut alla inmatade personer och tilldelar dem ett indexvärde med start 1 istället för 0.
        /// </summary>
        /// <param name="list"></param>
        public static void PrintList(List<Person> list)
        {
           var i = 1;
            foreach (var p in list)
            {
                
                Console.WriteLine("\n---------------------------------------------------------------");
                Console.WriteLine($"[{i}] Namn: {p.Name} Ålder: {p.Age} Antal bilar: {p.Cars.Count}");
                Console.WriteLine("---------------------------------------------------------------\n");
                
                i++;
            }
        }
    }
}