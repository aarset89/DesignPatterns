using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class Ebook : IEbook
    {
        public string FileName { get; private set; }

        public Ebook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading ebook " + FileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing ebook " + FileName);
        }
        public string GetFileName()
        {
            return FileName;
        }

    }
}
