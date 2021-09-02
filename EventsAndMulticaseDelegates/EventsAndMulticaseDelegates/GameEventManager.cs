using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndMulticaseDelegates
{
    class GameEventManager
    {
        // a new delegate type 
        public delegate void GameEvent();
        // create two delegates
        public static event GameEvent OnGameStart, OnGameOver;

        public static void  TriggerGameStart()
        {
            if(OnGameStart != null)
            {
                Console.WriteLine("The game has started...");

                OnGameStart();
            } 
        }

        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game has ended...");

                OnGameOver();
            }
        }
    }
}
