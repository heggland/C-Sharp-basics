using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;

            // declaring mutiple variables at once
            int num3, num4, num5;

            //assigning a value to a variable
            num1 = 13;

            // declaring and initializing a variable in one g
            int num2 = 23;
            int sum = num1 + num2;

            // displaying concatination
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2:" + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);

            string myname = "Ola";
            string message = "My name is: " + myname;

            string capsMessage = message.ToUpper();

            Console.WriteLine(capsMessage);

            Console.Read();


            NumberMethod();



        }

        /// <summary>
        /// This is xml documentation
        /// </summary>
        static void NumberMethod()
        {
            // code
        }
    }
}
