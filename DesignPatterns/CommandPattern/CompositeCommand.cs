using DesignPatterns.CommandPattern.Fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class CompositeCommand:Command
    {
        private List<Command> _commands = new List<Command>();

        public void AddCommand(Command command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach(var command in _commands)
                command.Execute();
        }
    }
}
