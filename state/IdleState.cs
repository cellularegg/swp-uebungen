using System;

namespace state
{
    public class IdleState : IPinballState
    {
        public void InsertCoin()
        {
            Console.WriteLine("You inserted another coin.");
        }

        public void StartPlaying()
        {
            Console.WriteLine("You Started playing.");
        }

        public void HitBall()
        {
            Console.WriteLine("You cannot hit the ball you must start playing first");
        }

        public void RaiseScore()
        {
            Console.WriteLine("You cannot raise the score you must start playing first");
        }

        public void LooseGame()
        {
            Console.WriteLine("You cannot loose the game you must start playing first");
        }

        public void WinGame()
        {
            Console.WriteLine("You cannot win the game you must start playing first");
        }
    }
}