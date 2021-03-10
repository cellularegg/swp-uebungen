using System;

namespace bridge
{
    public class LongSword : AbstractSword
    {
        public LongSword(ISpell spell, int damage, string name, int length) : base(spell, damage, name)
        {
            this.Length = Math.Max(30, length);
        }
    }
}