namespace visitor
{
    public class PointVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            ramp.Score *= ramp.Iterations;
        }

        public void Visit(Led led)
        {
            if (led.LedColor == Color.GREEN)
            {
                led.Score++;
            }
        }

        public void Visit(Target target)
        {
            target.Score++;
        }
    }
}