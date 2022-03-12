using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.Abuse
{
    public class RunningState : State
    {
        private StopWatch _stopWatch;
        public RunningState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void Click()
        {
            _stopWatch.SetCurrentState(new StoppedState(_stopWatch));
            Console.WriteLine("Stopped");
        }
    }
}
