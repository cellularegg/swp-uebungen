namespace bridge
{
    public class AbstractSpell: ISpell
    {
        public string SpellText { get; protected set; }
        public string GetSpellInCallrisch()
        {
            return SpellText.ToLower().Replace('a', 'o');
        }

        public string GetSpellInSelkisch()
        {
            return SpellText.ToUpper().Replace('A', 'U');
        }

    }
}