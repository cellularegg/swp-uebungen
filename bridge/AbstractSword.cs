using System;
using System.Drawing;

namespace bridge
{
    public class AbstractSword
    {
        protected ISpell Spell;

        public AbstractSword(ISpell spell, int damage, string name, int length = 0)
        {
            Spell = spell;
            Damage = Math.Max(0, damage);
            Name = name;
            Length = Math.Max(0, length);
        }

        public int Damage { get; }
        public string Name { get; }
        public int Length { get; protected set; }

        public string GetSpell(Position position)
        {
            if (Spell == null)
            {
                return string.Empty;
            }

            switch (position)
            {
                case Position.Left:
                    return Spell.GetSpellInSelkisch();
                    break;
                case Position.Right:
                    return Spell.GetSpellInCallrisch();
                    break;
                default:
                    return string.Empty;
            }
        }

        public override string ToString()
        {
            return $"Sword - Damage: {Damage}, Name: {Name}, Length: {Length}, Spell: {Spell?.SpellText}";
        }
    }
}