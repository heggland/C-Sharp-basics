using System;

namespace Coding_exercises
{
    internal class TestYourMethods
    {
        public static string ConvertToLowAndUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void CountLengthOfString(string s)
        {
            Console.WriteLine($"The amount of characters is {s.Length}");
        }

        public static void Run()
        {
            string s = "HeY ThErE !";

            s = ConvertToLowAndUpper(s);
            Console.WriteLine(s);
            CountLengthOfString(s);
        }
    }
}


