using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class Audi : Car
    {
        public string Model { get; set; }
        private string Brand { get; set; }
        public Audi(int horsePower, string clr, string model) : base(horsePower, clr)
        {
            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP: " + HP + " Color: " + Color);
        }

        public override void  Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
