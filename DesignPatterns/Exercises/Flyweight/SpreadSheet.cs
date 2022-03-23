using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Flyweight
{
    public class SpreadSheet
    {
        private static int MAX_ROWS = 3;
        private static int MAX_COLS = 3;

        private CellContextFactory _cellContextFactory;
        //private string _fontFamily = "Time new roman";
        //private int _fontSize = 12;
        //private bool _isBold = true;

        private Cell[,] _cells = new Cell[MAX_ROWS ,MAX_COLS];

        public SpreadSheet(CellContextFactory cellContextFactory)
        {
            _cellContextFactory = cellContextFactory;
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            ensureCellExists(row, col);

            _cells[row,col].SetContent(content);
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            ensureCellExists(row, col);

            var cell = _cells[row,col];
            var currentContext = cell.GetCellContext();
            var context = _cellContextFactory.GetCellContext(fontFamily, currentContext.FontSize, currentContext.IsBold);

            _cells[row,col].SetContext(context);
        }

        public void SetFontSize(int row, int col, int fontSize)
        {
            ensureCellExists(row,col);

            var cell = _cells[row,col];
            var currentContext = cell.GetCellContext();
            var context = _cellContextFactory.GetCellContext(currentContext.FontFamily, fontSize, currentContext.IsBold);

            _cells[row, col].SetContext(context);
        }

        public void SetIsBold(int row, int col, bool isBold)
        {
            var cell = _cells[row,col];
            var currentContext = cell.GetCellContext();
            var context = _cellContextFactory.GetCellContext(currentContext.FontFamily, currentContext.FontSize, isBold);

            _cells[row, col].SetContext(context);
        }

        private void ensureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentException();
        }

        private CellContext GetDefaultContext()
        {
            return new CellContext("Time new roman", 12, true);
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                {
                    var cell = new Cell(row, col, GetDefaultContext());
                    _cells[row,col] = cell;
                }
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    _cells[row,col].Render();
        }
    }
}
