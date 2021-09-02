﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndMulticaseDelegates
{
    class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals....");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
