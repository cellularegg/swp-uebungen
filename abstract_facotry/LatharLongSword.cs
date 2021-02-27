using System;
using System.Text;

namespace abstract_facotry
{
    public class LatharLongSword : ILongSword
    {
        public int Damage { get; }
        public int Weight { get; }
        public bool CanHurtAllies { get; }
        public bool TwoHanded { get; }
        
        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lathar Long Sword (Cannot hurt allies).");
            sb.AppendLine($"\tDamage: {Damage}");
            sb.AppendLine($"\tWeight: {Weight}");
            sb.AppendLine(TwoHanded ? "\tSword requires two hands." : "\tSword does not require two hands.");
            return sb.ToString();
            // throw new System.NotImplementedException();
        }

        public LatharLongSword(int damage, int weight, bool twoHanded)
        {
            CanHurtAllies = false;
            Damage = Math.Max(damage, 0);
            Weight = Math.Max(weight, 0);
            TwoHanded = twoHanded;
        }
    }
}