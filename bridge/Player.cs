using System;

namespace bridge
{
    public class Player
    {
        public Position Position { get; set; }
        public AbstractSword Sword { get; set; }

        public Player(Position position, SwordType swordType)
        {
            Position = position;
            switch (swordType)
            {
                case SwordType.Long:
                    Sword = new LongSword(new LongSpell(), 10, "Long sword", 100);
                    break;
                case SwordType.Short:
                    Sword = new ShortSword(new ShortSpell(), 5, "short sword", 20);
                    break;
            }
        }

        public void SaySpell()
        {
            Console.WriteLine(Sword.GetSpell(Position));
        }
    }
}