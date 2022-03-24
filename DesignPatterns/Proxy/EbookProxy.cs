using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class EbookProxy : IEbook
    {
        public string FileName { get; private set; }
        private Ebook _ebook;

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }
        public string GetFileName()
        {
            return FileName;
        }

        public void Show()
        {
            if (_ebook == null)
                _ebook = new Ebook(FileName);

            _ebook.Show();
        }
    }
}
