using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    public abstract class Car
    {
        // has a relationship
        private readonly CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string Owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = Owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The Car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }
        protected int HP { get; set; }
        protected string Color { get; set; }
        


     
        public Car(int horsePower, string clr)
        {
            this.Color = clr;
            this.HP = horsePower; 
        }
        public Car()
        {

        }
        public void ShowDetails()
        {
            Console.WriteLine("The color of the car is {0} and Horse Power is {1}", Color, HP);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
