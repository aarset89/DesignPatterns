using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Editor
{
    public class History
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command) => _commands.Add(command);

        public UndoableCommand Pop()
        {
            var his = _commands.Last();
            _commands.Remove(his);

            return his;
        }

        public int Size() => _commands.Count;
    }
}
