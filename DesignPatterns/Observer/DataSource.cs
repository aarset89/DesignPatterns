using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class DataSource : Subject
    {
        private int _value;

        public void SetValue(int value)
        {
            _value = value;
            NotifyObservers();
        }

        public int Value() => _value;



    }
}
