using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace members_and_finalizer_destructors
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salery;

        // member - public field
        public int age;

        // member - property - exposes JobTitle safely - properties start width a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salery is {salery}");
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salery = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        // only one per class
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }
    }
}
