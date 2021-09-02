using System;
using System.Collections.Generic;

namespace EventsAndMulticaseDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            
            Player player1 = new Player("Cat");
            Player player2 = new Player("Dog");
            Console.Write("Player 3: ");
            Player player3 = new Player(Console.ReadLine());

            // List<Player> players = new List<Player>() { player1), player2) };

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running.... Press any key to end the game.");
            Console.ReadKey();

            GameEventManager.TriggerGameOver();

            /*
            audioSystem.StartGame();
            renderingEngine.StartGame();

            foreach (Player player in players)
            {
                player.StartGame();
            }


            Console.WriteLine("Game is running.... Press any key to end the game.");
            Console.ReadKey();

            renderingEngine.GameOver();
            audioSystem.GameOver();


            foreach (Player player in players)
            {
                player.GameOver();
            }
            */

        }
    }
}
