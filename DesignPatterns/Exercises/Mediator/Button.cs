using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            NotifyObservers();
        }

        public bool GetEnabled()
        {
            return _isEnabled;
        }
    }
}
