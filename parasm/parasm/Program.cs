using System;

namespace parasm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7}={8}", 1, 2, 3, 4, 5, 6, 7, 9, 1 + 2 + 3 + 4 + 5 + 6 + 7);

            ParamsMethod("This", " is", " a ", "long", " sentance");
            Console.WriteLine("\n");
            ParamsMethod2("This", " is", " a ", "short", " sentance");
            */


            int minMath = Math.Min(100, -500); // only work with 2 values

            int min = MinV2(6, -4, -8, 6, 1, 5); // custum method accept multiple values

            Console.WriteLine(minMath);
            Console.WriteLine(min);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        public static void ParamsMethod(params string[] sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Console.Write(sentance[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
