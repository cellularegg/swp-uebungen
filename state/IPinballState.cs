namespace state
{
    public interface IPinballState
    {
        void InsertCoin();
        void StartPlaying();
        void HitBall();
        void RaiseScore();
        void LooseGame();
        void WinGame();
    }
}