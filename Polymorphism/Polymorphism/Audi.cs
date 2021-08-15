using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Audi : Car
    {

        private string Brand = "Audi";
        public string Model { get; set; }

        public Audi(int HP, string Color, string Model) : base(HP, Color)
        {
            this.Model = Model;
        }

        public new void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Brand: {Brand}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} car was repaired!");
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
