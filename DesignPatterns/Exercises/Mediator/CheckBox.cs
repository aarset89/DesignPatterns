using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Mediator
{
    public class CheckBox : UIControl
    {
        private bool _isChecked;

        public void SetChecked(bool check)
        {
            _isChecked = check;
            NotifyObservers();
        }

        public bool IsChecked()
        {
            return _isChecked;
        }
    }
}
