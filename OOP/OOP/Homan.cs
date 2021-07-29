using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // this class is a blueprint for a datatype
    class Homan
    {
        // member variable
        // public vs private: public means one can alter firstName from another file.
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // default constructor
        public Homan()
        {
            Console.WriteLine("Default constructor called. Object created");
        }


        // parameterized constructor
        public Homan(string firstName)
        {
            this.firstName = firstName;
        }
        public Homan(string firstName, string lastname)
        {
            this.firstName = firstName;
            this.lastName = lastname;
        }
        public Homan(string firstName, string lastname, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.eyeColor = eyeColor;
        }

        public Homan(string firstName, string lastname, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Homan(string firstName, string lastname, int age)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.age = age;
        }

        // member method
        public void IntrouduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} ", firstName);
            }
        }

    }
}
