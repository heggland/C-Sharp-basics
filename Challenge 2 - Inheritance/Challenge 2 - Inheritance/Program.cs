using System;

namespace Challenge_2___Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss Chuck = new Boss("Ferrari", "Chuck Norris", "Chuck", 999);
            Chuck.Lead();

            Employee Espen = new Employee("Espen Askeladd", "Espen", 300);
            Espen.Work();

            Trainees Michael = new Trainees(2, 6, "Michael Jis", "Michael", 500);
            Michael.Learn();
            Michael.Work();
        }
    }
}
