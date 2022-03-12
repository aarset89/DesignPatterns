using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Abuse
{
    public class StoppedState : State
    {
        private StopWatch _stopWatch;
        public StoppedState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void Click()
        {
            _stopWatch.SetCurrentState(new RunningState(_stopWatch));
            Console.WriteLine("Running");

        }
    }
}
