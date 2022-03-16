using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.CommandPattern
{
    public abstract class AbstractUndoableCommand : UndoableCommand
    {
        protected History _history;
        protected VideoEditor _editor;

        public AbstractUndoableCommand(VideoEditor editor, History history)
        {
            _editor = editor;
            _history = history;
        }

        public void Execute()
        {
            DoExecute();

            _history.Push(this);
        }

        public void Unexecute()
        {
            DoUnexecute();
        }

        protected abstract void DoExecute();
        protected abstract void DoUnexecute();
    }
}
