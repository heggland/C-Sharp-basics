using System;
using System.Collections.Generic;
using System.Text;

namespace abstracts
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double Length)
        {
            this.Length = Length;
            Name = "Cube";
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nThe Cube has a length of {Length}");
        }
    }
}
