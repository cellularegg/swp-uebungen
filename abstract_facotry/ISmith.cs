namespace abstract_facotry
{
    public interface ISmith
    {
        IShortSword GetShortSword();
        ILongSword GetLongSword();
    }
}