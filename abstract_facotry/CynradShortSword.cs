using System;
using System.Text;

namespace abstract_facotry
{
    public class CynradShortSword : IShortSword
    {
        public int Damage { get; }
        public int Weight { get; }

        public bool Glows { get; }

        public bool Throwable { get; }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cynrad Short Sword (Glows in the Dark).");
            sb.AppendLine($"\tDamage: {Damage}");
            sb.AppendLine($"\tWeight: {Weight}");
            sb.AppendLine(Throwable ? "\tSword can be thrown." : "\tSword cannot be thrown.");
            return sb.ToString();
        }

        public CynradShortSword(int damage, int weight, bool throwable)
        {
            Glows = true;
            Damage = Math.Max(damage, 0);
            Weight = Math.Max(weight, 0);
            Throwable = throwable;
        }
    }
}