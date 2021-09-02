using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndMulticaseDelegates
{
    class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
