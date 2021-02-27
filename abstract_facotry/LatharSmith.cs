namespace abstract_facotry
{
    public class LatharSmith : ISmith
    {
        public IShortSword GetShortSword()
        {
            return new LatharShortSword(12, 6, false);
        }

        public ILongSword GetLongSword()
        {
            return new LatharLongSword(17, 8, false);
        }
    }
}