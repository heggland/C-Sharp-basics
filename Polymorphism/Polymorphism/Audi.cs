using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi : Car
    {
        public string Model { get; set; }

        private string Brand = "Audi";

        public Audi(int HP, string Color, string Model) : base(HP, Color)
        {
            this.Model = Model;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Brand: {Brand}");
        }

        public void Status()
        {
            if (base.HP == 100)
            {
                Console.WriteLine("Car got 100% HP");
            }
            else
            {
                Console.WriteLine("Car is ruined");
                Console.WriteLine(base.HP);
            }
        }

    }
}
