using System;

namespace state
{
    public class PlayingBeginnerState : IPinballState
    {
        public void InsertCoin()
        {
            Console.WriteLine("Wow you are skilled inserting a coin while playing");
        }

        public void StartPlaying()
        {
            Console.WriteLine("You are already playing in beginner mode");
        }

        public void HitBall()
        {
            Console.WriteLine("You hit the ball successfully");
        }

        public void RaiseScore()
        {
            Console.WriteLine("Congrats you raised the score");
        }

        public void LooseGame()
        {
            Console.WriteLine("Oh no you lost at the start");
        }

        public void WinGame()
        {
            Console.WriteLine("You cannot win the game yet. You just started playing.");
        }
    }
}