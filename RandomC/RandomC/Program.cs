using System;

namespace RandomC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);

                Console.WriteLine(numEyes);
            }
            */

            //Example();
            Oz();
        }

        static void Example()
        {
            Random value = new Random();
            int number;

            for (int i = 0; i < 10; i++)
            {
                number = value.Next(1, 4);

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Yes" + number);
                        break;
                    case 3:
                        Console.WriteLine("No" + number);
                        break;
                    default:
                        Console.WriteLine("Maybe" + number);
                        break;
                }

            }

        }

        static void Oz()
        {
            Console.WriteLine("Wizzard of Oz grant you one question. What will you ask him? ");
            Console.ReadLine();
            switch (new Random().Next(1, 4)) { case 1: Console.WriteLine("Yes"); break; case 2: Console.WriteLine("No"); break; default: Console.WriteLine("Maybe"); break; }
        }
    }
}
