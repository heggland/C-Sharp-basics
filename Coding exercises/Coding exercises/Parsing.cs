using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class Parsing
    {
        public static void Run()
        {
            string intString = "22";
            string floatString = "13.1";

            int numberInt = Int16.Parse(intString);
            double numberFloat = Convert.ToDouble(floatString);

            Console.WriteLine(numberInt.ToString(), numberFloat.ToString());
        }
    }
}
