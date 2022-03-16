using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PullStyle
{
    public class DataSource : Subject
    {
        private int _value;

        public void SetValue(int value)
        {
            _value = value;
            Notifyobservers();
        }

        public int GetValue() => _value;
    }
}
