namespace visitor
{
    public  class Led : IElement
    {
        private static int _counter = 0;
        public int Number { get; set; }
        public bool IsActive { get; set; }
        public Color LedColor { get; set; }
        public int Score { get; set; }

        public Led(Color ledColor)
        {
            Number = _counter++;
            IsActive = false;
            LedColor = ledColor;
            Score = 1;
        }

        public override string ToString()
        {
            return $"{nameof(Number)}: {Number}, {nameof(IsActive)}: {IsActive}, {nameof(LedColor)}: {LedColor}, " +
                   $"{nameof(Score)}: {Score}";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}