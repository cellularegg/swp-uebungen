using System;

namespace state
{
    public class PlayingExpertMode : IPinballState
    {
        public void InsertCoin()
        {
            Console.WriteLine("Wow you are skilled inserting a coin while playing in expert mode.");
        }

        public void StartPlaying()
        {
            Console.WriteLine("You are already playing in expert mode");
        }

        public void HitBall()
        {
            Console.WriteLine("You hit the ball successfully in expert mode");
        }

        public void RaiseScore()
        {
            Console.WriteLine("Congrats you raised the score in expert mode");
        }

        public void LooseGame()
        {
            Console.WriteLine("Oh no you lost at expert mode");
        }

        public void WinGame()
        {
            Console.WriteLine("You Won!!!!");
        }
    }
}