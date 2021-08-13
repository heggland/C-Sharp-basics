using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2___Inheritance
{
    class Boss : Employee
    {

        public string CompanyCar { get; set; }

        public Boss(string CompanyCar, string Name, string FirstName, int Salery) : base(Name, FirstName, Salery)
        {
            this.CompanyCar = CompanyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"I'm leading. My name is {Name}");
        }

    }
}
