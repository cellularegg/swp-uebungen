namespace abstract_facotry
{
    public interface ISword
    {
        public int Damage { get; }
        public int Weight { get; }
        public string GetStats();
    }
}