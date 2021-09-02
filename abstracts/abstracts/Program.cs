using System;

namespace abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cube firkant = new Cube(2);
            firkant.GetInfo();

            Sphere sirkel = new Sphere(2);
            sirkel.GetInfo();
            */

            Shape[] shapes = { new Sphere(4), new Cube(3) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name} has a Volume of {cube2.Volume()}");


            }
        }
    }
}
