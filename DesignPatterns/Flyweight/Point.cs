using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public PointIcon Icon { get; private set; }
        

        public Point(int x, int y, PointIcon icon)
        {
            X = x;
            Y = y;
            //PointType = pointType;
            //Icon = icon;
            Icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine(string.Format(@"{0} at ({1}, {2} )", Icon.PointType, X, Y));
        }

    }
}
