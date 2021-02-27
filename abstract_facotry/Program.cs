using System;

namespace abstract_facotry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1's smith is Cynrad");
            Player p1 = new Player(SmithType.Cynrad);
            Console.WriteLine("Player 1's Short Sword");
            Console.WriteLine(p1.ShortSword.GetStats());
            Console.WriteLine("Player 1's Long Sword");
            Console.WriteLine(p1.LongSword.GetStats());
            Console.WriteLine("Player 2's smith is Lathar");
            Player p2 = new Player(SmithType.Lathar);
            Console.WriteLine("Player 2's Short Sword");
            Console.WriteLine(p2.ShortSword.GetStats());
            Console.WriteLine("Player 2's Long Sword");
            Console.WriteLine(p2.LongSword.GetStats());
        }
    }
}