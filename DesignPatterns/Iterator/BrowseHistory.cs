using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private Iterator _iterator;
        private List<string> urls = new List<string>();
        //public BrowseHistory(Iterator iterator)
        //{
        //    _iterator = iterator;
        //}

        public Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var lastUrl = urls.Last();
            urls.Remove(lastUrl);
            return lastUrl;
        }

        public class ListIterator : Iterator
        {
            private BrowseHistory _browseHistory;
            private int index;
            public ListIterator(BrowseHistory browseHistory)
            {
                _browseHistory = browseHistory;
            }
            public string Current()
            {
                return _browseHistory.urls.ElementAt(index);
            }

            public bool HasNext()
            {
                return (index < _browseHistory.urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
