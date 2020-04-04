using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismC
{
    class M3:BMW
    {

        public M3(int horsePower, string clr, string model): base(horsePower, clr, model)
        {
            this.Model = model;
        }


        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }
}
