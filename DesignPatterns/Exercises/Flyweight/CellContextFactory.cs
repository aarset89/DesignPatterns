using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Flyweight
{
    public class CellContextFactory
    {
        private Dictionary<int, CellContext> _cellContexts = new Dictionary< int, CellContext>();

        public CellContext GetCellContext(string fontFamily, int fontSize, bool isBold)
        {
            var hash = (new { fontFamily, fontSize, isBold }).GetHashCode();
            
            if(!_cellContexts.ContainsKey(hash))
            {
                _cellContexts.Add(hash, new CellContext(fontFamily, fontSize, isBold));
            }

            return _cellContexts[hash];
        }

    }
}
