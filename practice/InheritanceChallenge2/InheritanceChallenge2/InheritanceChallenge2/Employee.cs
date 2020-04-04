using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge2
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            Name = "Panjuta";
            FirstName = "Denis";
            Salary = 5000;
        }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary; 
        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
