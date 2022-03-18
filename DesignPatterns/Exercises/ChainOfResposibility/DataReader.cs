using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ChainOfResposibility
{
    public class DataReader
    {
        private Handler _handler;

        public DataReader(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(File file)
        {
            _handler.Handle(file);
        }

        //public void read(string fileName)
        //{
        //    if (fileName.EndsWith(".xls"))
        //    {
        //        Console.WriteLine("Reading data from an Excel spreadsheet.");
        //    }
        //    else if (fileName.EndsWith(".numbers"))
        //    {
        //        Console.WriteLine("Reading data from a Numbers spreadsheet.");
        //    }
        //    else if (fileName.EndsWith(".qbw"))
        //    {
        //        Console.WriteLine("Reading data from a QuickBooks file.");
        //    }
        //    else
        //        throw new Exception("File format not supported.");
        //}
    }
}
