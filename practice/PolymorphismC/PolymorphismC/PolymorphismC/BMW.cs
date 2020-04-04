using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class BMW : Car
    {
        private int horsePower;
        private string clr;

        public string Model { get; set; }
        private string Brand { get; set; }
        public BMW(int horsePower, string clr, string model) : base(horsePower, clr)
        {
            this.Model = model;
        }
      

        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + Brand + " HP: " + HP + " Color: " + Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }

    }
}
