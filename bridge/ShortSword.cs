using System;

namespace bridge
{
    public class ShortSword : AbstractSword
    {
        public ShortSword(ISpell spell, int damage, string name, int length) : base(spell, damage, name)
        {
            this.Length = Math.Min(30, length);
        }
    }
}