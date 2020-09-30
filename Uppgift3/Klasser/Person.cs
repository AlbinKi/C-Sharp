using System;
using System.Collections.Generic;

namespace Klasser
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Car> Cars { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Cars = new List<Car>();
        }

       
        
    }

}