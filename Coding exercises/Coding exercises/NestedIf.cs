using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class NestedIf
    {

        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else
            {
                if (number % 2 != 0)
                    Console.WriteLine("Odd number.");
                else
                    Console.WriteLine("Even number.");
            }
        }

        public void Run()
        {
            NestedCheck(4);
        }
    }
}
