using System;
using System.Text;

namespace abstract_facotry
{
    public class CynradLongSword : ILongSword
    {
        public int Damage { get; }
        public int Weight { get; }
        public bool Glows { get; }
        public bool TwoHanded { get; }
        
        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cynrad Long Sword (Glows in the Dark).");
            sb.AppendLine($"\tDamage: {Damage}");
            sb.AppendLine($"\tWeight: {Weight}");
            sb.AppendLine(TwoHanded ? "\tSword requires two hands." : "\tSword does not require two hands.");
            return sb.ToString();
            // throw new System.NotImplementedException();
        }

        public CynradLongSword(int damage, int weight, bool twoHanded)
        {
            Glows = true;
            Damage = Math.Max(damage, 0);
            Weight = Math.Max(weight, 0);
            TwoHanded = twoHanded;
        }

    }
}