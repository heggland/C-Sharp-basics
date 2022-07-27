using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class BreakAndContinue
    {
        public static void Run()
        {
            int i = -10;

            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                    break;
                Console.WriteLine(i++);
            }
        }
    }
}

