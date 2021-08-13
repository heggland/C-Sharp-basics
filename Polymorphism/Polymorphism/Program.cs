using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi(40, "Red", "A4");
            audi.ShowDetails();
            audi.Repair();
            audi.Status();
        }
    }
}
