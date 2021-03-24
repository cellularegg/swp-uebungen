namespace visitor
{
    public interface IVisitor
    {
        void Visit(Ramp ramp);
        void Visit(Led led);
        void Visit(Target target);
    }
}