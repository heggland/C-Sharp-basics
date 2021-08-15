using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class M3 : BMW
    {
        public M3(int HP, string Color, string Model) : base(HP, Color, Model)
        {

        }

        /*
        // sealed key word
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
