using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.CommandPattern
{
    public class History
    {
        private List<UndoableCommand> _undoableCommands = new List<UndoableCommand>();

        public void Push(UndoableCommand undoableCommand) => _undoableCommands.Add(undoableCommand);

        public UndoableCommand Pop()
        {
            var lastCommand = _undoableCommands.Last();
            _undoableCommands.Remove(lastCommand);
            return lastCommand;
        }
        public int Size() => _undoableCommands.Count;
    }
}
