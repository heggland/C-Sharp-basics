using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            start();

            Console.ReadKey();
        }

        static void start()
        {
            /*
            Console.WriteLine("Please give first name");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please give last name");
            string lastname = Console.ReadLine();

            Console.WriteLine("Please give your age");
            string eyeColor = Console.ReadLine();

            Console.WriteLine("Please give us your eyecolor");
            string age = Console.ReadLine();
            */

            Homan user = new Homan("Ola", "Nord", "Blue", 17);
            Homan user2 = new Homan("Martin", "Nord", "Red");
            Homan user3 = new Homan("Martin", "Nord");
            Homan user4 = new Homan("Martin");
            Homan user5 = new Homan("Martin", "Jacob", 94);

            // create an object of my class
            // Homan user = new Homan(firstname, lastname, eyeColor, age);


            // access public variable from outside the class
            // user.firstName = firstname; <- string in Homan.cs must be public
            // user.lastName = lastname; <- string in Homan.cs must be public
            // call methods of the class
            user.IntrouduceMyself();
            user2.IntrouduceMyself();
            user3.IntrouduceMyself();
            user4.IntrouduceMyself();
            user5.IntrouduceMyself();

            Homan basicHuman = new Homan();
            basicHuman.IntrouduceMyself();
        }
    }
}



// https://code-maze.com/csharp-basics-access-modifiers/