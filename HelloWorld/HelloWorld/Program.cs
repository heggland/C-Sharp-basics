using System; // System contains a bunch of classes, like console.WriteLine

namespace HelloWorld
{
    class Program
    {
        //entr point of our program
        //something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.
        //void = doesnt return anything
        //main = method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Read();

        }
    }
}
