using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndMulticaseDelegates
{
    class AudioSystem
    {

        public AudioSystem()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine("Audio System Started");
            Console.WriteLine("Playing Audio....");
        }

        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
