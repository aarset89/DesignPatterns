using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Flyweight
{
    public class Cell
    {
        private int _row;
        private int _column;
        private string _content;
        
        //private string _fontFamily;
        //private int _fontSize;
        //private bool _isBold;

        private CellContext _cellContext;

        public Cell(int row, int column, CellContext cellContext)
        {
            _row = row;
            _column = column;
            _cellContext = cellContext;
        }

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public void SetContext(CellContext cellContext)
            => _cellContext = cellContext;

        public CellContext GetCellContext() => _cellContext;

        //public string GetFontFamily()
        //{
        //    return _cellContext.FontFamily;
        //}

        //public void SetFontFamily(string fontFamily)
        //{
        //    _fontFamily = fontFamily;
        //}

        //public int GetFontSize()
        //{
        //    return _cellContext.FontSize;
        //}

        //public void SetFontSize(int fontSize)
        //{
        //    _fontSize = fontSize;
        //}

        //public bool IsBold()
        //{
        //    return _cellContext.IsBold;
        //}

        //public void SetBold(bool bold)
        //{
        //    _isBold = bold;
        //}
        public void Render()
        {
            Console.WriteLine(@"({0}, {1}): {2} [{3}]", _row, _column, _content, _cellContext.FontFamily);
        }
    }
}
