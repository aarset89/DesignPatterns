using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.TemplateMethod
{
    public class CodeBefore
    {
        public void SomeAction()
        {
            Console.WriteLine("Execute some code before closing window");
        }
        
        public void SomeOtherAction()
        {
            Console.WriteLine("Execute SomeOtherAction code before closing window");
        }
    }
}
