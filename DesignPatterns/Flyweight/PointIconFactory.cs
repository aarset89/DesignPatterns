using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!_icons.ContainsKey(pointType))
            {
                _icons.Add(pointType, new PointIcon(pointType, null));

            }
             var icon = _icons[pointType];

            return icon;
        }
    }
}
