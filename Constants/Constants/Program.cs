using System;

namespace Constants
{
    class Program
    {
        const double pi = 3.141592653589793238;
        const byte weeks = 52, months = 12;
        const int days = 365;
        const string date = "01.01.01";

        static void Main(string[] args)
        {
            Console.WriteLine(date);
            Console.ReadKey();
        }
    }
}
