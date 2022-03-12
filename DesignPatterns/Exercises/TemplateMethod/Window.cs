using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.TemplateMethod
{
    public class Window: WindowBase
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Some action in windows class");
        }
    }
}
