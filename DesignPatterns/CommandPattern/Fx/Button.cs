using DesignPatterns.CommandPattern.Fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Fx
{
    public class Button
    {
        private string _label { get; set; }
        private Command _command;

        public Button(Command command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }

    }
}
