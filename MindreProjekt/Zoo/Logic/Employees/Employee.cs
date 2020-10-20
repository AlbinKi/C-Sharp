using System;
namespace Logic
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Competence { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
            
        } 
    }
}
