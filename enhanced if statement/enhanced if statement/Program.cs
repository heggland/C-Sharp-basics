using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enhanced_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //[condition] ? [first expression] : [second expression]
            //condition has to be either true or false

            //The conditional Operator is right-associative
            //That means, that a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e)

            //The conditional Operator cannot be overloaded.

            start();

        }

        static void start(uint temperature = 0)
        {
            Console.WriteLine("input temp");
            try
            {
                doTemp(Convert.ToUInt32(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, try again");
                start();
            }
        }

        static void doTemp(uint temperature)
        {
            string stateOfTemp;

            //The same result can be achieved by this
            //The enhanced Version of the If-Else-Statement from above
            stateOfTemp = temperature <= 15 ? "t is too cold here" : (temperature >= 16 && temperature <= 28 ? "it is ok" : "it is hot here");

            Console.WriteLine("The tempature is {0}", temperature <= 15 ? "t is too cold here" : (temperature >= 16 && temperature <= 28 ? "it is ok" : "it is hot here"));
            //Console.WriteLine("The tempature is {0}", temperature <= 15 ? "t is too cold here" : (temperature >= 16 && temperature <= 28 ? "it is ok" : "it is hot here"));

            start();

            Console.Read();
        }


    }
}
