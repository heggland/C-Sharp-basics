using System;

namespace highscore
{
    class Program
    {

        static uint highscore;
        static string highscorePlayer = "";

        static void Main(string[] args)
        {
            setHighscore();
            startHighscore();
        }

        static void setHighscore()
        {
            Console.WriteLine("Set a highscore number");
            highscore = Convert.ToUInt32(Console.ReadLine());
        }

        static void startHighscore()
        {
            if (highscorePlayer != "")
            {
                Console.WriteLine($"Current highscore held by {highscorePlayer}");
            }

            Console.WriteLine("Try beat the highscore");
            updateHighscore(Convert.ToUInt32(Console.ReadLine()));
        }

        static void updateHighscore(uint score)
        {
            if (score > highscore)
            {

                Console.WriteLine($"New highscore!\nLast: {highscore} \nCurrent: {score}\n");
                highscore = score;
                Console.Write("Set highscore name: ");
                highscorePlayer = Console.ReadLine();
                Console.WriteLine("Restarting..");
                startHighscore();
            }
            else
            {
                Console.WriteLine("Try again");
                startHighscore();
            }
        }
    }
}
