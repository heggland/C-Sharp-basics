using System;

namespace Functions_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write something: ");

            string text = WriteSomething(Console.ReadLine());

            Console.WriteLine($"Text go brrrrrr: {text}");
               
            Console.Read();
        }

        public static string WriteSomething(string text)
        {
            return String.Concat("You wrote: ", text);
        }

    }
}
