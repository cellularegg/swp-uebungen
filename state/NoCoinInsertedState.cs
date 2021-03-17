using System;

namespace state
{
    public class NoCoinInsertedState : IPinballState
    {
        public void InsertCoin()
        {
            Console.WriteLine("Coin Inserted.");
        }

        public void StartPlaying()
        {
            Console.WriteLine("Cannot play without coins."); 
        }

        public void HitBall()
        {
            Console.WriteLine("You cannot hit a ball insert a coin first.");
        }

        public void RaiseScore()
        {
            Console.WriteLine("You cannot raise the score insert a coin first.");
        }

        public void LooseGame()
        {
            Console.WriteLine("You cannot loose a game insert a coin first.");
        }

        public void WinGame()
        {
            Console.WriteLine("You cannot win a game insert a coin first.");
        }
    }
}