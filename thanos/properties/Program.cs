using System;

namespace properties
{
    class Program
    {


        static void Main(string[] args)
        {
            Box box = new Box(2, 2, 2);
            //box.length = 3;
            //box.SetLenght(5);   // encapsulatition
            //box.height = 4;
            //box.Height = 5;
            //box.width = 5;
            //box.width = 8;
            //Console.WriteLine($"Box lenght is {box.length}");


            box.DisplayInfo();  // encapsulatition

            int lenghtValue = box.GetLength();
            Console.WriteLine($"Lenght: {lenghtValue}");
            //Console.WriteLine($"Box volume is: {box.GetVolume()}");
            Console.WriteLine($"Box volume is: {box.Volume}");
        }
    }
}
