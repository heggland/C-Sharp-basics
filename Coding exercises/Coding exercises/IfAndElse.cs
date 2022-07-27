using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class IfAndElse
    {

        public static void CheckIfEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public void Run()
        {
            CheckIfEvenOrOdd(4);
        }
    }
}
