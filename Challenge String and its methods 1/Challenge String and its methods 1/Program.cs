using System;

namespace Challenge_String_and_its_methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            string nameTrimmed = String.Format("Trimmed: {0}", name.Trim());
            string nameSubString = String.Format("Substring value: {0}", name.Substring(0, 5));
            Console.WriteLine($"Your name is {name}".ToLower());
            Console.WriteLine($"Your name is {name.ToUpper()}");
            Console.WriteLine(nameTrimmed);
            Console.WriteLine(nameSubString);

            Console.ReadKey();
        }
    }
}
