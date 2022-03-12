using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.TemplateMethod
{
    public abstract class WindowBase
    {
        private CodeBefore _codeBefore;

        public WindowBase()
        {
            _codeBefore = new CodeBefore();
        }

        public WindowBase(CodeBefore codeBefore)
        {
            _codeBefore = codeBefore;
        }

        public void Close()
        {
            _codeBefore.SomeAction();

            DoExecute();
            Console.WriteLine("Removing the window from the screen");

            _codeBefore.SomeOtherAction();
        }

        protected virtual void DoExecute()
        {
            Console.WriteLine("Some oaction in base class");
        }
    }
}
