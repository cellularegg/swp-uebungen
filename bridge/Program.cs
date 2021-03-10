using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(Position.Left, SwordType.Short);
            p1.SaySpell();
            p1.Position = Position.Right;
            p1.SaySpell();
            Player p2 = new Player(Position.Right, SwordType.Long);
            p2.SaySpell();
            p2.Position = Position.Left;
            p2.SaySpell();
        }
    }
}