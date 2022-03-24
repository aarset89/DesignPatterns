using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy : IEbook
    {
        public string FileName { get; private set; }
        private Ebook _ebook;
        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }
        public string GetFileName()
        {
            return FileName;
        }

        public void Show()
        {
            if(_ebook == null)
                _ebook = new Ebook(FileName);
            Console.WriteLine("Logging TASK");

            _ebook.Show();
        }
    }
}
