using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class ArraysForLoopsforeachLoops
    {
        void GetOdd(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        void GetEven(int[] Array)
        {
            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }
    }
}
