using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PullStyle
{
    public class Spreadsheet : Observer
    {
        private DataSource _dataSource;

        public Spreadsheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Spreadsheet got updated" + _dataSource.GetValue());
        }
    }
}
