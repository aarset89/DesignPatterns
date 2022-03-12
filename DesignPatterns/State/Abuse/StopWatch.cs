using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Abuse
{
    public class StopWatch
    {
        private State _currentState;
        public StopWatch()
        {
            _currentState = new StoppedState(this);
        }

        public void Click()
        {
            _currentState.Click();
        }

        public void SetCurrentState(State currentState)
        {
            this._currentState = currentState;
        }

        public State GetCurrentState()
        {
            return _currentState;
        }
    }
}
