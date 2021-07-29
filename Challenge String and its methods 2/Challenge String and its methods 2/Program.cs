using System;

namespace Challenge_String_and_its_methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the character to search:");
            char searchInput = Console.ReadLine()[0];
            Console.WriteLine($"Searched character found in index spot {input.IndexOf(searchInput)}");

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            string name = string.Concat(firstName + " " + lastName);
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
