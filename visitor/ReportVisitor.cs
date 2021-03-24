using System;

namespace visitor
{
    public class ReportVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            Console.WriteLine($"Rampe \"{ramp.Name}\": {(ramp.IsOpen ? "geöffnet" : "geschlossen")}, " +
                              $"{ramp.Iterations} Durchläufe, {(ramp.IsBlinking ? "blinkt" : "blinkt nicht")}, " +
                              $"{ramp.Score} Punkte.");
        }

        public void Visit(Led led)
        {
            Console.WriteLine($"LED {led.Number}: {(led.IsActive ? "aktiv" : "nicht aktiv")} -> {led.LedColor}, " +
                              $"{led.Score} Punkte.");
        }

        public void Visit(Target target)
        {
            Console.WriteLine($"Target \'{target.Letter}\', {(target.IsUp ? "oben" : "unten")} {target.Score} Punkte");
        }
    }
}