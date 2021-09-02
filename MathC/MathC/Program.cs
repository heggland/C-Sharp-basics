using System;

namespace MathC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));



            int num1 = 13;
            int num2 = 9;
            Console.WriteLine($"Lower of num1: {num1} and num2 {num2} is {Math.Min(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is: {Math.Pow(3, 5)}");

            Console.WriteLine($"The square root of 25 is: {Math.Sqrt(25)}");

            Console.WriteLine($"Always positive is: {Math.Abs(-25)}");

            Console.WriteLine($"Cos of 1 is: {Math.Cos(1)}");
        }
    }
}
