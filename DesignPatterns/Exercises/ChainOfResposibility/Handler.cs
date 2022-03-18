using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ChainOfResposibility
{
    public abstract class Handler
    {
        private Handler _next;
        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(File file)
        {
            if (file.FileName.EndsWith(GetExtension()))
            {
                DoHandle(file);
                return;
            }

            if (_next != null)
                _next.Handle(file);
            else throw new Exception("File format not supported");
        }
        public abstract bool DoHandle(File file);
        public abstract string GetExtension();
    }
}
