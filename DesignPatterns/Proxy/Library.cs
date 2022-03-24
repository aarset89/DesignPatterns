using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> _library = new Dictionary<string, IEbook>();

        public void AddEbook(IEbook ebook)
        {
            _library.Add(ebook.GetFileName(), ebook);
        }

        public void LoadEbook(string fileName)
        {
            _library[fileName].Show();
        }
    }
}
