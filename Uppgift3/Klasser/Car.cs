using System;

namespace Klasser
{
    public class Car
    {
        public string Reg { get; set; }
        public string Model { get; set; }
        public string Electric { get; set; }
        public int Weight { get; set; }
      

        public DateTime RegisterDate { get; set; }

        public Car(string model, string reg, int weight, bool electric)
        {
            

            Model = model;
            Reg = reg;
            Weight = weight;

            if (electric)
            {
                Electric = "Det är en elbil";
            }
            else 
            {
                Electric = "Det är inte en elbil";
            }   
            
            RegisterDate = DateTime.Now;
        }

       

    }
}