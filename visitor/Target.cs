namespace visitor
{
    public class Target : IElement
    {

        public char Letter { get; set; }
        public bool IsUp { get; set; }
        public int Score { get; set; }

        public Target(char letter)
        {
            Letter = letter;
            IsUp = true;
            Score = 1;
        }

        public override string ToString()
        {
            return $"{nameof(Letter)}: {Letter}, {nameof(IsUp)}: {IsUp}, {nameof(Score)}: {Score}";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}