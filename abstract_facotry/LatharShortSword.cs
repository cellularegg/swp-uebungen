using System;
using System.Text;

namespace abstract_facotry
{
    public class LatharShortSword : IShortSword
    {
        public int Damage { get; }
        public int Weight { get; }

        public bool CanHurtAllies { get; }

        public bool Throwable { get; }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lathar Short Sword (Cannot hurt allies).");
            sb.AppendLine($"\tDamage: {Damage}");
            sb.AppendLine($"\tWeight: {Weight}");
            sb.AppendLine(Throwable ? "\tSword can be thrown." : "\tSword cannot be thrown.");
            return sb.ToString();
        }

        public LatharShortSword(int damage, int weight, bool throwable)
        {
            CanHurtAllies = false;
            Damage = Math.Max(damage, 0);
            Weight = Math.Max(weight, 0);
            Throwable = throwable;
        }
    }
}