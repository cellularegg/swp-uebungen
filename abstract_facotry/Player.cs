using System;
using System.Data.Common;
using System.Net;

namespace abstract_facotry
{
    public class Player
    {
        public IShortSword ShortSword { get; }
        public ILongSword LongSword { get; }
        public Player(SmithType smithTypeType)
        {
            ISmith smith;
            switch (smithTypeType)
            {
                case SmithType.Lathar:
                    smith = new LatharSmith();
                    break;
                case SmithType.Cynrad:
                    smith = new CynradSmith();
                    break;
                default:
                    throw new ArgumentException();
            }
            ShortSword = smith.GetShortSword();
            LongSword = smith.GetLongSword(); 
        }
    }
}