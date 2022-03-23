using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Flyweight
{
    public class CellContext
    {
        public string FontFamily{get; private set;}
        public int FontSize{get; private set;}
        public bool IsBold { get; private set; }

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            IsBold = isBold;
        }

        public int GetHash()
        {
            var ob = new {FontFamily, FontSize, IsBold};
            return ob.GetHashCode();
        }
    }
}
