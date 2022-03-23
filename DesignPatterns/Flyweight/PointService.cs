using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class PointService
    {
        private PointIconFactory _pointIconFactory;
        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }

        public List<Point> GetPoints()
        {
            var points = new List<Point>();
            points.Add(new Point(1, 2, _pointIconFactory.GetPointIcon(PointType.HOSPITAL)));
            points.Add(new Point(3, 4, _pointIconFactory.GetPointIcon(PointType.HOSPITAL)));
            points.Add(new Point(3, 4, _pointIconFactory.GetPointIcon(PointType.CAFE)));


            return points;

        }


    }
}
