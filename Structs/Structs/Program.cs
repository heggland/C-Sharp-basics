using System;

namespace Structs
{

    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine($"Game 1's name is: \t\t{name}");
            Console.WriteLine($"Game 1's was developed: \t{developer}");
            Console.WriteLine($"Game 1's rating is: \t\t{rating}");
            Console.WriteLine($"Game 1 was released in: \t{releaseDate}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Game game1;


            game1.name = "Dota 2";
            game1.developer = "Valve";
            game1.rating = 4.5;
            game1.releaseDate = "09.07.2013";

            game1.Display();

        }
    }
}
