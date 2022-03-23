using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public  class PointIcon
    {
        public PointType PointType { get; private set; }
        public byte[] Icon { get; private set; }

        public PointIcon(PointType pointType, byte[] icon)
        {
            PointType = pointType;
            Icon = icon;
        }
    }
}
