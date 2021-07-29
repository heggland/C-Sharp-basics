using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine(num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);


            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is:  {0}", num);
            // post increment
            Console.WriteLine("num is:  {0} post increment", num++);
            Console.WriteLine("num is:  {0}", num);
            /// pre increment
            Console.WriteLine("num is:  {0} pre increment", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is:  {0}", num);

            // relational and type operators
            bool isLower;
            isLower = num < num2;
            Console.WriteLine(isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            isEqual = num1 != num2;

            // conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            isLowerAndSunny = isLower || isSunny;

            Console.ReadKey();
        }
    }
}
