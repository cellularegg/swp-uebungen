using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Pinball myPinball = new Pinball();
            Console.WriteLine($"Games to play: {myPinball.Coins}");
            myPinball.InsertCoin();
            myPinball.InsertCoin();
            myPinball.StartPlaying();
            myPinball.RaiseScore();
            myPinball.RaiseScore();
            myPinball.RaiseScore();
            myPinball.WinGame();
            Console.WriteLine($"Games to play: {myPinball.Coins}");
            myPinball.LooseGame();
            myPinball.StartPlaying();
            myPinball.LooseGame();
            myPinball.StartPlaying();
            myPinball.LooseGame();
            myPinball.StartPlaying();
            myPinball.LooseGame();
            myPinball.StartPlaying();
        }
    }
}