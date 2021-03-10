namespace bridge
{
    public interface ISpell
    {
        public string SpellText { get; }
        public string GetSpellInCallrisch();
        public string GetSpellInSelkisch();
    }
}