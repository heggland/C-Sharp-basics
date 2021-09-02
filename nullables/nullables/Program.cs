using System;

namespace nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1234;

            double? num3 = new Double?();
            double? num4 = 4.14157;

            bool? boolval1 = new bool?();
            bool? boolval2 = true;

            Console.WriteLine("Our nullable numbers are: \n{0},\n{1},\n{2},\n{3}", num1, num2, num3, num4);
            Console.WriteLine();
            Console.WriteLine("The nullable boolean value is: \n{0},\n{1}", boolval1, boolval2);
            Console.WriteLine();

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender choosen");
            }

            // convert nullable double to normal double
            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6; ;
            }

            Console.WriteLine("Value of num 8 is " + num8);

            // sorter: the null coalescing operator ??

            num8 = num7 ?? 8.53;

            Console.WriteLine("Value of num 8 is " + num8);

        }
    }
}
