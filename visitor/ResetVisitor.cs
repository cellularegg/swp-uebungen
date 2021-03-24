namespace visitor
{
    public class ResetVisitor : IVisitor
    {
        public void Visit(Ramp ramp)
        {
            ramp.Iterations = 0;
            ramp.IsOpen = false;
        }

        public void Visit(Led led)
        {
            led.IsActive = false;
        }

        public void Visit(Target target)
        {
            target.IsUp = true;
        }
    }
}