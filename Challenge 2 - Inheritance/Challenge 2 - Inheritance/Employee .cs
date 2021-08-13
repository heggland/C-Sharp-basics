using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2___Inheritance
{
    class Employee
    {
        private static bool working = false;

        // properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        // Default constructor.
        public Employee()
        {
            Name = "Ola Nordmann";
            FirstName = "Ola";
            Salary = 200;
        }

        // Instance constructor that has three parameters
        public Employee(string Name, string FirstName, int Salary)
        {
            this.Name = Name;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        public virtual void Work()
        {
            if (!working)
            {
                working = true;
                Console.WriteLine($"{this.FirstName} is working..");
            }
        }

        public void Pause()
        {
            if (working)
            {
                working = false;
                Console.WriteLine($"{this.FirstName} is on a break..");
            }
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object.
        public override string ToString()
        {
            return String.Format($"{this.FirstName} earns {this.Salary}");
        }
    }
}
