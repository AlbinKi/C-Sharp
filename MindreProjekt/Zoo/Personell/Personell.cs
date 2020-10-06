using System;
namespace PersonellLibrary
{
    public class Personell
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Competence { get; set; }

        public Personell(string name, int age)
        {
            Name = name;
            Age = age;
            
        }

        private static Personell AssignWorkerProperties()
        {
            Console.WriteLine("Vad heter skötaren?");
            var name = Console.ReadLine();
            Console.WriteLine("Hur gammal är skötaren?");
            var age = int.Parse(Console.ReadLine());
   

            Personell worker = new Personell(name, age);

            return worker;
        }


        public static Personell AddWorker()
        {
            string[] workers = new string[7] { "Apskötare", "Björnskötare", "Delfinskötare", "Elefantskötare", "Giraffskötare", "Lejonskötare", "Pingvinskötare" };
            int number = 1;
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"[{number}] {workers[i]}");
                number++;
            }
            

            Console.WriteLine("\n Skriv in siffran för den typ av skötare du vill lägga till.");
            var isNumber = true;
            var workerChooser = 0;

            do
            {
                if (!isNumber)
                {
                    Console.WriteLine("Ange endast en siffra mellan 1-7");
                }

                isNumber = int.TryParse(Console.ReadLine(), out workerChooser);

                if (workerChooser >= 8 || workerChooser <= 0)
                {
                    isNumber = false;
                }

            } while (!isNumber);



            switch (workerChooser)
            {
                case 1:

                    {
                        var worker = AssignWorkerProperties();
                        worker = new MonkeyDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 2:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new BearDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 3:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new DolphineDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 4:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new ElephantDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 5:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new GiraffeDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 6:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new LionDude(worker.Name, worker.Age);
                        return worker;
                    }

                case 7:
                    {
                        var worker = AssignWorkerProperties();
                        worker = new PenguinDude(worker.Name, worker.Age);
                        return worker;
                    }
            }
            return null;

        }
    }
}
