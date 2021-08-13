using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2___Inheritance
{
    class Trainees : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainees() { }

        public Trainees(int WorkingHours, int SchoolHours, string Name, string FirstName, int Salery) : base(Name, FirstName, Salery)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"{FirstName} is a trainee. Currently studying. Trainee works {SchoolHours}h each day.");
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} is a trainee. Currently working. Trainee works {WorkingHours}h each day");
        }


        public override string ToString()
        {
            return String.Format($"{FirstName} is a trainee");
        }

    }
}


