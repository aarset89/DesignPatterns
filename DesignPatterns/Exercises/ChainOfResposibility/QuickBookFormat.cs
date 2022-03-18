using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ChainOfResposibility
{
    public class QuickBookFormat : Handler
    {
        public QuickBookFormat(Handler next) : base(next)
        {
        }

        public override bool DoHandle(File file)
        {
            Console.WriteLine("NOT Quick format, Continue");

            return false;
        }

        public override string GetExtension()
        {
            return ".qwb";
        }
    }
}
