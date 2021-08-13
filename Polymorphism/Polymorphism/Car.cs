using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int HP, string Color)
        {
            this.HP = HP;
            this.Color = Color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Car stats:");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Color: {Color}");
        }

        public void Repair()
        {
            HP = 100;
            Console.WriteLine("Car was repaired!");
        }
    }
}
