namespace abstract_facotry
{
    public class CynradSmith : ISmith
    {
        public IShortSword GetShortSword()
        {
            return new CynradShortSword(10, 5, true);
        }

        public ILongSword GetLongSword()
        {
            return new CynradLongSword(20, 10, true);
        }
    }
}