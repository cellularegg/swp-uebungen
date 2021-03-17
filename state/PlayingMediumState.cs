using System;

namespace state
{
    public class PlayingMediumState : IPinballState
    {
        public void InsertCoin()
        {
            Console.WriteLine("Wow you are skilled inserting a coin while playing in medium mode.");
        }

        public void StartPlaying()
        {
            Console.WriteLine("You are already playing in medium mode");
        }
        public void HitBall()
        {
            Console.WriteLine("You hit the ball successfully in medium mode");
        }

        public void RaiseScore()
        {
            Console.WriteLine("Congrats you raised the score in medium mode");
        }

        public void LooseGame()
        {
            Console.WriteLine("Oh no you lost at medium mode");
        }

        public void WinGame()
        {
            Console.WriteLine("You cannot win the game yet. You are only playing in medium mode.");
        }
    }
}