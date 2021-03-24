namespace visitor
{
    public  class Ramp : IElement
    {
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public int Score { get; set; }
        public int Iterations { get; set; }
        public bool IsBlinking { get; set; }

        public Ramp(string name, bool isBlinking, int iterations)
        {
            Name = name;
            IsBlinking = isBlinking;
            IsOpen = false;
            Score = 1;
            Iterations = iterations;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(IsOpen)}: {IsOpen}, {nameof(Score)}: {Score}, {nameof(Iterations)}: " +
                   $"{Iterations}, {nameof(IsBlinking)}: {IsBlinking}";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}