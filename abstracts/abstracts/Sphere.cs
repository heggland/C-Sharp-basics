using System;
using System.Collections.Generic;
using System.Text;

namespace abstracts
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double Radius)
        {
            this.Radius = Radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return Math.Pow(Radius, 3) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe Sphere has a radius of {Radius}");
        }
    }
}
