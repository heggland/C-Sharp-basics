using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Audi audi = new Audi(40, "Red", "A4");
            audi.ShowDetails();
            audi.Repair();
            audi.Status();
            */

            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "Black", "23");
            Car audiA3 = new Audi(100, "Green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIdInfo(1234, "Dennis");
            audiA3.SetCarIdInfo(1235, "Frank");
            bmwZ3.GetCarIdInfo();
            audiA3.GetCarIdInfo();

            BMW bmwM5 = new BMW(330, "White", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Red", "M3 Super");
            myM3.Repair();

        }
    }
}
