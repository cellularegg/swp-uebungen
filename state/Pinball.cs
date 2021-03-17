using System.Drawing;

namespace state
{
    public class Pinball
    {
        public IPinballState PinballState { get; set; }
        public int Coins { get; private set; }

        public Pinball()
        {
            PinballState = new NoCoinInsertedState();
        }

        public void InsertCoin()
        {
            PinballState.InsertCoin();
            Coins++;
            if (PinballState is NoCoinInsertedState)
            {
                PinballState = new IdleState();
            }
        }

        public void StartPlaying()
        {
            PinballState.StartPlaying();
            if (!(PinballState is NoCoinInsertedState) && (Coins - 1) > 0)
            {
                Coins--;
                PinballState = new PlayingBeginnerState();
            }
        }

        public void HitBall()
        {
            PinballState.HitBall();
        }

        public void RaiseScore()
        {
            PinballState.RaiseScore();
            if (PinballState is PlayingBeginnerState)
            {
                PinballState = new PlayingMediumState();
            }
            else if (PinballState is PlayingMediumState)
            {
                PinballState = new PlayingExpertMode();
            }
        }

        public void LooseGame()
        {
            PinballState.LooseGame();
            if ((Coins - 1) > 0)
            {
                Coins--;
                PinballState = new PlayingBeginnerState();
            }
            else
            {
                PinballState = new NoCoinInsertedState();
            }
        }

        public void WinGame()
        {
            PinballState.WinGame();
            if (PinballState is PlayingExpertMode)
            {
                Coins++;
            }
        }
    }
}